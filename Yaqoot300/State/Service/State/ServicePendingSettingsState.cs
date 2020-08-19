using System;

namespace Yaqoot300.State.Service
{
    public class ServicePendingSettingsState
    {
        public int? ActiveReaders { get; set; }
        public int? FeedInSteps { get; set; }
        public int? M3StepLength { get; set; }
        public int? M3Speed { get; set; }
        public int? M4Speed { get; set; }
    }
}