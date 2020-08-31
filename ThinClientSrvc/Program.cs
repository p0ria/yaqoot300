using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Common;

namespace ThinClientSrvc
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = Config.FromFile.Client1;
            var connection = new TCConnection(config.Ip, config.Port);
            connection.Listen();

            Console.ReadKey(true);

        }
    }
}
