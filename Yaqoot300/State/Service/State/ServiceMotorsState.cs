namespace Yaqoot300.State.Service
{
    public class ServiceMotorsState
    {
        public ServiceMotorState M0 { get; set; }
        public ServiceMotorState M1 { get; set; }
        public ServiceMotorState M2 { get; set; }
        public ServiceMotorState M3 { get; set; }
        public ServiceM4State M4 { get; set; }

        public ServiceMotorsState()
        {
            M0 = new ServiceMotorState();
            M1 = new ServiceMotorState();
            M2 = new ServiceMotorState();
            M3 = new ServiceMotorState();
            M4 = new ServiceM4State();
        }
    }
}