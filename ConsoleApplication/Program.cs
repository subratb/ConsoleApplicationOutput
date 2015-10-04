using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
                Console.WriteLine(string.Format("Hello {0}!", args[0]));
            Console.WriteLine(string.Format("Program Finished!"));
        }
    }
}
