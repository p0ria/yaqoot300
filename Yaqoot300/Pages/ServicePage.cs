using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.Commons;
using Yaqoot300.Controls;
using Yaqoot300.Interfaces;
using Yaqoot300.Modals;
using Yaqoot300.State;
using Yaqoot300.State.Job.Actions;
using Yaqoot300.State.Service;
using Yaqoot300.State.Service.Actions;

namespace Yaqoot300.Pages
{
    public partial class ServicePage : UserControl
    {
        private SensorControl[] _sensors;
        private TestReaderControl[] _testReaders;
        private SetupReaderControl[] _setupReaders;
        public ServicePage()
        {
            InitializeComponent();
            Store.StoreChanged += OnStoreChanged;
            this.InitSensorControls();
            this.InitTestReaders();
            this.InitSetupReaders();
        }

        private void InitSensorControls()
        {
            this._sensors = new SensorControl[Constants.SENSORS_LENGTH];
            _sensors[0] = sensor1;
            _sensors[1] = sensor2;
            _sensors[2] = sensor3;
            _sensors[3] = sensor4;
            _sensors[4] = sensor5;
            _sensors[5] = sensor6;
            _sensors[6] = sensor7;
            _sensors[7] = sensor8;
            _sensors[8] = sensor9;
            _sensors[9] = sensor10;
            _sensors[10] = sensor11;
            _sensors[11] = sensor12;
            _sensors[12] = sensor13;
            _sensors[13] = sensor14;
        }

        private void InitTestReaders()
        {
            this._testReaders = new TestReaderControl[Constants.READERS_COUNT];
            _testReaders[0] = tr1;
            _testReaders[1] = tr2;
            _testReaders[2] = tr3;
            _testReaders[3] = tr4;
            _testReaders[4] = tr5;
            _testReaders[5] = tr6;
            _testReaders[6] = tr7;
            _testReaders[7] = tr8;
            _testReaders[8] = tr9;
            _testReaders[9] = tr10;
            _testReaders[10] = tr11;
            _testReaders[11] = tr12;
            _testReaders[12] = tr13;
            _testReaders[13] = tr14;
            _testReaders[14] = tr15;
            _testReaders[15] = tr16;
            _testReaders[16] = tr17;
            _testReaders[17] = tr18;
            _testReaders[18] = tr19;
            _testReaders[19] = tr20;
            _testReaders[20] = tr21;
            _testReaders[21] = tr22;
            _testReaders[22] = tr23;
            _testReaders[23] = tr24;
            _testReaders[24] = tr25;
            _testReaders[25] = tr26;
            _testReaders[26] = tr27;
            _testReaders[27] = tr28;
            _testReaders[28] = tr29;
            _testReaders[29] = tr30;
            this.btnTestReaders.BtnClicked += OnBtnTestReadersClicked; 
        }

        private void InitSetupReaders()
        {
            this._setupReaders = new SetupReaderControl[Constants.READERS_COUNT];
            _setupReaders[0] = sr1;
            _setupReaders[1] = sr2;
            _setupReaders[2] = sr3;
            _setupReaders[3] = sr4;
            _setupReaders[4] = sr5;
            _setupReaders[5] = sr6;
            _setupReaders[6] = sr7;
            _setupReaders[7] = sr8;
            _setupReaders[8] = sr9;
            _setupReaders[9] = sr10;
            _setupReaders[10] = sr11;
            _setupReaders[11] = sr12;
            _setupReaders[12] = sr13;
            _setupReaders[13] = sr14;
            _setupReaders[14] = sr15;
            _setupReaders[15] = sr16;
            _setupReaders[16] = sr17;
            _setupReaders[17] = sr18;
            _setupReaders[18] = sr19;
            _setupReaders[19] = sr20;
            _setupReaders[20] = sr21;
            _setupReaders[21] = sr22;
            _setupReaders[22] = sr23;
            _setupReaders[23] = sr24;
            _setupReaders[24] = sr25;
            _setupReaders[25] = sr26;
            _setupReaders[26] = sr27;
            _setupReaders[27] = sr28;
            _setupReaders[28] = sr29;
            _setupReaders[29] = sr30;
            foreach (var sr in this._setupReaders)
            {
                sr.Assigned += (s, e) => AssignReader(lbReaders.SelectedItem.ToString(), sr.Number);
            }
            this.lbReaders.SelectedIndexChanged += lbReadersOnSelectedIndexChanged;
        }

        private void AssignReader(string readerName, int readerNumber)
        {
            this.lbReaders.ClearSelected();
            this.Store.Dispatch(new ServiceAssignReaderAction(new ServiceAssignReaderActionPayload(readerName, readerNumber)));
        }

        private void lbReadersOnSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            foreach (var sr in this._setupReaders)
            {
                sr.IsActive = this.lbReaders.SelectedIndex > -1;
            }
        }

        private void OnBtnTestReadersClicked(object sender, EventArgs eventArgs)
        {
            ChangeBtnTestReadersStatus(LoadingButtonControl.LoadingButtonControlStatus.Loading);
            Store.Dispatch(new ServiceTestReadersAction());
        }

        

        private void ChangeBtnTestReadersStatus(LoadingButtonControl.LoadingButtonControlStatus status)
        {
            this.btnTestReaders.Status = status;
        }

        private void OnStoreChanged(object sender, string changeType)
        {
            switch (changeType)
            {
                case null:
                    SetSensors();
                    SetTestReaders();
                    SetSetupReaders();
                    break;
                case ServiceActionTypes.TEST_READERS:
                    SetTestReaders();
                    break;
                case ServiceActionTypes.TEST_READERS_SUCCESS:
                case ServiceActionTypes.TEST_READERS_FAIL:
                    SetTestReaders();
                    ChangeBtnTestReadersStatus(LoadingButtonControl.LoadingButtonControlStatus.Visible);
                    break;
                case ServiceActionTypes.ASSIGN_READER:
                    SetSetupReaders();
                    break;
                case ServiceActionTypes.SENSORS_CHANGED:
                    SetSensors();
                    break;
            }
        }


        private Store Store => Services.Store;

        private void SetSensors()
        {
            this.SafeInvoke(() =>
            {
                for (int i = 0; i < Constants.SENSORS_LENGTH; i++)
                {
                    _sensors[i].IsOn = Store.Service.Sensors[i];
                }
            });
        }


        private void SetSetupReaders()
        {
            this.SafeInvoke(() =>
            {
                var unassginedReaders = Store.Service.SetupReaders.Readers.Where(r => !r.ReaderNumber.HasValue);
                var assignedReaders = Store.Service.SetupReaders.Readers.Where(r => r.ReaderNumber.HasValue);

                this.lbReaders.Items.Clear();
                this.lbReaders.Items.AddRange(unassginedReaders.Select(r => r.ReaderName).ToArray());
                foreach (var sr in assignedReaders)
                {
                    _setupReaders[sr.ReaderNumber.Value - 1].ReaderName = sr.ReaderName;
                }
            });        
        }

        private void SetTestReaders()
        {
            this.SafeInvoke(() =>
            {
                for (int i = 0; i < Constants.READERS_COUNT; i++)
                {
                    _testReaders[i].Status = Store.Service.TestReaders.Readers[i];
                }
            });
        }

        private void btnSelectJob_Click(object sender, EventArgs e)
        {
            using (var dlg = new JobsDialog())
            {
                dlg.ShowDialog();
                Store.Dispatch(new JobSelectJobAction(dlg.SelectedJobId));
            }
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            Services.Messages.ShowDialog();
        }

    }
}
