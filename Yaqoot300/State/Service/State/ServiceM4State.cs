using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service
{
    public class ServiceM4State
    {
        public bool IsUpEnabled { get; set; }
        public bool IsDownEnabled { get; set; }
        public UpDownMotorStatus Status { get; set; }
    }
}