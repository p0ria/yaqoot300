using Shared.Common;

namespace Yaqoot300.Interfaces
{
    public class Signal
    {
        public string Name { get; set; }
        public byte[] value { get; set; }

        public string Hex
        {
            get { return Utils.ByteArrayToHexString(value); }
        }
    }
}