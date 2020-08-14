namespace Yaqoot300.State.PLC
{
    public class InitialPlcState
    {
        private static readonly PlcState _instance = new PlcState
        {
            IsStartReady = false
        };

        public static PlcState Instance => _instance;
    }
}