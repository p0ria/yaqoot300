using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaqoot300.Properties;

namespace Yaqoot300.Commons
{
    public static class IBA
    {
        static IBA()
        {
            Icon_Error_32x32 = Utils.ImageToByteArray(Resources.icon_error_32x32);
            Icon_Warning_32x32 = Utils.ImageToByteArray(Resources.icon_warning_32x32);
            Icon_Info_32x32 = Utils.ImageToByteArray(Resources.icon_info_32x32);
        }

        public static byte[] Icon_Error_32x32 { get; }
        public static byte[] Icon_Warning_32x32 { get; }
        public static byte[] Icon_Info_32x32 { get; }
    }
}
