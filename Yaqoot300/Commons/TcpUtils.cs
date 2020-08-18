using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Yaqoot300.Commons
{
    public static class TcpUtils
    {
        public static void ReleasePort(int port)
        {
            //Create process
            var pProcess = new Process();

            //strCommand is path and file name of command to run
            pProcess.StartInfo.FileName = "cmd.exe";

            //strCommandParameters are parameters to pass to program
            pProcess.StartInfo.Arguments = $"/c netstat -ano | findstr :{port}";

            pProcess.StartInfo.UseShellExecute = false;

            //Set output of program to be written to process output stream
            pProcess.StartInfo.RedirectStandardOutput = true;

            //Start the process
            pProcess.Start();

            //Get program output
            var strOutput = pProcess.StandardOutput.ReadToEnd().Trim().Split(' ');
            //Wait for process to finish
            pProcess.WaitForExit();

            try
            {
                int processId = int.Parse(strOutput[strOutput.Length - 1]);
                var target = Process.GetProcessById(processId);
                target.Kill();
                target.WaitForExit();
            }
            catch (Exception ex)
            {
                // ignored
            }
        }
    }
}
