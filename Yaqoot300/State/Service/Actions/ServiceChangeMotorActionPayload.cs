using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceChangeMotorActionPayload
    {
        public ServiceChangeMotorActionPayload(RotateMotorStatus status) : this(status, null) { }
        public ServiceChangeMotorActionPayload(bool isEnabled) : this(null, isEnabled) { }

        public ServiceChangeMotorActionPayload(RotateMotorStatus? status, bool? isEnabled)
        {
            this.Status = status;
            this.IsEnabled = isEnabled;
        }
        public bool? IsEnabled { get; set; }
        public RotateMotorStatus? Status { get; set; }
    }
}