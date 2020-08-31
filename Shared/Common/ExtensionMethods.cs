using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Shared.ThinClient.Requests;

namespace Shared.common
{
    public static class ExtensionMethods
    {
        public static T DeepClone<T>(this T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }

        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        public static OSLoadRequest AsOSLoadRequest(this TCRequest @this)
        {
            var osLoadRequest = new OSLoadRequest();
            if (@this.Payload is IEnumerable<string>)
            {
                osLoadRequest.Readers = (IEnumerable<string>) @this.Payload;
            }
            return osLoadRequest;
        }
    }
}
