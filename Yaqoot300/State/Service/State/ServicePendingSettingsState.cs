using System;

namespace Yaqoot300.State.Service
{
    public class ServicePendingSettingsState : ServiceSettingsState
    {
        public ServicePendingSettingsState(ServiceSettingsState settings, Guid? id = null)
        {
            this.Id = id ?? Guid.NewGuid();
            this.ActiveReaders = settings.ActiveReaders;
            this.FeedInSteps = settings.FeedInSteps;
            this.M3StepLength = settings.M3StepLength;
            this.M4Speed = settings.M4Speed;
        }
        public Guid Id { get; set; }
    }
}