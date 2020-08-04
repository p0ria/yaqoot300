using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceChangeM4ActionPayload
    {
        public ServiceChangeM4ActionPayload(UpDownMotorStatus status) : this(status, null, null) { }

        public ServiceChangeM4ActionPayload(UpDownMotorStatus? status, bool? isUpEnabled, bool? isDownEnabled)
        {
            this.Status = status;
            this.IsUpEnabled = isUpEnabled;
            this.IsDownEnabled = isDownEnabled;
        }
        public bool? IsUpEnabled { get; set; }
        public bool? IsDownEnabled { get; set; }
        public UpDownMotorStatus? Status { get; set; }
    }
}