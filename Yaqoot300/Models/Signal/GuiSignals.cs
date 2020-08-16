

using Yaqoot300.Commons;

namespace Yaqoot300.Models.Signal
{
    public static class GuiSignals
    {
        public static readonly byte[] Start = {0x81, 0x01};
        public static readonly byte[] Started = { 0x81, 0x02 };
        public static readonly byte[] Stop = { 0x82, 0 };
        public static readonly byte[] ManualCycle = { 0x83, 0 };
        public static readonly byte[] ManualOsLoad = { 0x84, 0 };
        public static readonly byte[] ManualFeedIn = { 0x85, 0 };
        public static readonly byte[] OSLoadFinished = { 0x86, 0 };
        public static readonly byte[] ServiceNumOfActiveReaders = { 0x87 };
        public static readonly byte[] ServiceNumOfFeedInStep = { 0x88 };
        public static readonly byte[] ServiceM4Speed = { 0x89 };
        public static readonly byte[] ServiceM3StepLength = { 0x8A };
        public static readonly byte[] ServiceM4Up = { 0x8B, 0x01 };
        public static readonly byte[] ServiceM4Down = { 0x8B, 0x02 };
        public static readonly byte[] ServiceM3Run = { 0x8C, 0x01 };
        public static readonly byte[] ServiceM0Run = { 0x8C, 0x02 };
        public static readonly byte[] ServiceM0Stop = { 0x8C, 0xF2 };
        public static readonly byte[] ServiceM1Run = { 0x8C, 0x03 };
        public static readonly byte[] ServiceM1Stop = { 0x8C, 0xF3 };
        public static readonly byte[] ServiceM2Run = { 0x8C, 0x04 };
        public static readonly byte[] ServiceM2Stop = { 0x8C, 0xF4 };
    }
}