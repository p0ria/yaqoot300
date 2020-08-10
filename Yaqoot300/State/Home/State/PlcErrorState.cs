using System.Runtime.CompilerServices;

namespace Yaqoot300.State.Home
{
    public enum PlcErrorType
    {
        Error, Warning
    }

    public static class PlcErrors
    {
        public static PlcErrorState DoorOpen;
        public static PlcErrorState EndOfReel;

        static PlcErrors()
        {
            DoorOpen = new PlcErrorState(1, PlcErrorType.Error, "Door is open");
            EndOfReel = new PlcErrorState(2, PlcErrorType.Warning, "End of reel");
        }
    }
    public class PlcErrorState
    {
        public int Id { get; set; }
        public PlcErrorType Type { get; set; }
        public string Message { get; set; }

        public PlcErrorState(int id, PlcErrorType type, string message)
        {
            this.Id = id;
            this.Type = type;
            this.Message = message;
        }
    }
}