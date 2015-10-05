using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utility;

namespace ConsoleApplicationOutputGet
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(@"ConsoleApplication.exe", @"Subrat");
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            Process p = Process.Start(startInfo);

            StandardOutput so = new StandardOutput(p.StandardOutput);

            //so.ReadAsString(readBuffer=>OnChunk(readBuffer)).Then()

            string output = p.StandardOutput.ReadToEnd();
            Console.WriteLine(string.Format("Output from original program: {0}",output));
            Console.ReadLine();
            p.WaitForExit();
        }

        //private static bool OnChunk(ArraySegment<byte> readBuffer)
        //{
        //    if (IsKeepAlive(readBuffer))
        //    {                
        //        return false;
        //    }

        //    return true;
        //}
        //private static bool IsKeepAlive(ArraySegment<byte> readBuffer)
        //{
        //    return readBuffer.Count == 1
        //        && readBuffer.Array[readBuffer.Offset] == (byte)' ';
        //}

        //private void OnMessage(string message)
        //{
        //    //connection.Trace(TraceLevels.Messages, "LP: OnMessage({0})", message);

        //    //var shouldReconnect = ProcessResponse(connection, message);

        //    //if (IsReconnecting(connection))
        //    //{
        //    //    // If the timeout for the reconnect hasn't fired as yet just fire the 
        //    //    // event here before any incoming messages are processed
        //    //    TryReconnect(connection, _reconnectInvoker);
        //    //}

        //    //if (shouldReconnect)
        //    //{
        //    //    // Transition into reconnecting state
        //    //    connection.EnsureReconnecting();
        //    //}


        //}

    }
}
