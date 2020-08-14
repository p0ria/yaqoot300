﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.Commons;
using Yaqoot300.Interfaces;
using Yaqoot300.Models.Signal;
using Yaqoot300.State.Home.Actions;
using Yaqoot300.State.PLC.Actions;

namespace Yaqoot300.State.Home
{
    public class HomeReducer : IReducer<HomeState>
    {
        public void Reduce(HomeState state, IAction action)
        {
            switch (action.Type)
            {
                case HomeActionTypes.CHANGE_AUTO_START:
                    var changeAutoStartPayload = ((HomeChangeAutoStartAction)action).Payload;
                    if (changeAutoStartPayload.Status.HasValue)
                    {
                        state.Auto.StartBtn.Status = changeAutoStartPayload.Status.Value;
                        Services.Messages.Info("Auto Button State Changed To " + state.Auto.StartBtn.Status, MessageCategory.App);
                        switch (changeAutoStartPayload.Status)
                        {
                            case AutoStartBtnStatus.Starting:
                                Task.Run(async () =>
                                {
                                    var canStart = await Services.CheckingsService.CanStart();
                                    switch (canStart)
                                    {
                                        case null:
                                            Services.Messages.Info("Start is in progress", MessageCategory.App);
                                            break;
                                        case true:
                                            Services.Store.Dispatch(new HomeChangeAutoStartAction(
                                                new HomeChangeAutoStartActionPayload(AutoStartBtnStatus.Started, true)));
                                            break;
                                        case false: 
                                            Services.Store.Dispatch(new HomeChangeAutoStartAction(
                                                new HomeChangeAutoStartActionPayload(AutoStartBtnStatus.Stoped, true)));       
                                            break;
                                    }
                                });
                                break;
                            case AutoStartBtnStatus.Started:
                                Services.Signals.Send(GuiSignals.Started);
                                break;
                            case AutoStartBtnStatus.Stoped:
                                Services.Signals.Send(GuiSignals.Stop);
                                Services.Store.Dispatch(new PlcStartReadyChangedAction(false));
                                break;
                        }

                    }
                    if (changeAutoStartPayload.IsEnabled != null)
                        state.Auto.StartBtn.IsEnabled = changeAutoStartPayload.IsEnabled.Value;
                    break;

                case HomeActionTypes.ADD_PLC_ERROR:
                    var addPlcErrorPayload = ((HomeAddPlcErrorAction)action).Payload;
                    if (state.PlcErrors.Any(error => error.Id != addPlcErrorPayload.Id))
                    {
                        state.PlcErrors.Add(addPlcErrorPayload);
                        if(addPlcErrorPayload.Type == PlcErrorType.Error) Services.Messages.Error(addPlcErrorPayload.Message, MessageCategory.PLC);
                        else Services.Messages.Warning(addPlcErrorPayload.Message, MessageCategory.PLC);
                    }
                    break;

                case HomeActionTypes.REMOVE_PLC_ERROR:
                    var removePlcErrorPayload = ((HomeRemovePlcErrorAction)action).Payload;
                    state.PlcErrors.RemoveAll(error => error.Id == removePlcErrorPayload);
                    break;

                case HomeActionTypes.LOAD_OS:
                    state.HomeReaders.Readers.ForEach(r =>
                    {
                        if(Services.Store.Service.SetupReaders[r.ReaderNumber] != null)
                            r.Status = ReaderStatus.Busy;
                    });
                    break;

                case HomeActionTypes.LOAD_OS_SUCCESS:
                    var updateReadersPayload = ((HomeLoadOSSuccess)action).Payload;
                    state.HomeReaders.Readers.ForEach(r =>
                    {
                        var readerName = Services.Store.Service.SetupReaders[r.ReaderNumber];
                        var update = updateReadersPayload.FirstOrDefault(u => u.ReaderName.Equals(readerName));
                        if (update != null)
                        {
                            r.Status = update.Status;
                            r.Total++;
                            r.Good = update.Status == ReaderStatus.Success ? r.Good + 1 : r.Good;
                        }
                        else
                        {
                            r.Status = ReaderStatus.Idle;
                        }
                    });
                    break;

                case HomeActionTypes.LOAD_OS_FAIL:
                    MessageBox.Show("LOAD OS FAILED");
                    state.HomeReaders.Readers.ForEach(r => r.Status = ReaderStatus.Fail);
                    break;
            }
        }
    }
}
