using System.Runtime.CompilerServices;

namespace Yaqoot300.State.Home
{
    public enum PlcErrorType
    {
        Error, Warning
    }

    public static class PlcErrors
    {
        public static PlcErrorState Emergency;
        public static PlcErrorState DoorsOpen;
        public static PlcErrorState PowerFail;
        public static PlcErrorState HomePosition;
        public static PlcErrorState InputBufferEmpty;
        public static PlcErrorState InputSpacerEmpty;
        public static PlcErrorState OutputBufferFull;
        public static PlcErrorState OutputSpacerEmpty;
        public static PlcErrorState InputReelSensorEmpty;
        public static PlcErrorState OutputReelSensorEmpty;
        public static PlcErrorState ChipPositionSensor;
        public static PlcErrorState ReaderOperationSensor;

        static PlcErrors()
        {
            Emergency = new PlcErrorState(2, PlcErrorType.Error, "Emergency");
            DoorsOpen = new PlcErrorState(4, PlcErrorType.Error, "Doors are open");
            PowerFail = new PlcErrorState(6, PlcErrorType.Error, "Power Fail");
            HomePosition = new PlcErrorState(8, PlcErrorType.Error, "Home Position");
            InputBufferEmpty = new PlcErrorState(10, PlcErrorType.Error, "Input Buffer Empty");
            InputSpacerEmpty = new PlcErrorState(12, PlcErrorType.Error, "Input Spacer Empty");
            OutputBufferFull = new PlcErrorState(14, PlcErrorType.Error, "Output Buffer Full");
            OutputSpacerEmpty = new PlcErrorState(16, PlcErrorType.Error, "Output Spacer Empty");
            InputReelSensorEmpty = new PlcErrorState(18, PlcErrorType.Error, "Input Reel Sensor Empty");
            OutputReelSensorEmpty = new PlcErrorState(20, PlcErrorType.Error, "Output Reel Sensor Empty");
            ChipPositionSensor = new PlcErrorState(22, PlcErrorType.Error, "Chip Postion Sensor");
            ReaderOperationSensor = new PlcErrorState(24, PlcErrorType.Error, "Reader Operation Sensor");
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