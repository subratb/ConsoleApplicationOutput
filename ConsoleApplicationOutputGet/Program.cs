using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string output = p.StandardOutput.ReadToEnd();
            Console.WriteLine(string.Format("Output from original program: {0}",output));
            Console.ReadLine();
            p.WaitForExit();
        }
    }
}
