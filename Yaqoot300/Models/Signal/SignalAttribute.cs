using System;

namespace Yaqoot300.Models.Signal
{
    public class SignalAttribute : Attribute
    {
        public SignalAttribute(params byte[] index)
        {
            this.Index = index;
        }

        public byte[] Index { get; private set; }
    }
}