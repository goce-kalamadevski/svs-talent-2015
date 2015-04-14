using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to start execution...");
            Console.ReadLine();
                if (args.Length > 5)
            {
                throw new ApplicationException("Maximum number of arguments exceeded!");
            }
            int _maxNumberOfArguments = Int32.Parse(System.Configuration.ConfigurationManager.AppSettings["MaxNumberOfArguments"]);
            Console.WriteLine("MaxNumberOfArguments= {0}", _maxNumberOfArguments);
            //TODO Add code to write "HelloWorld" string here
            Console.WriteLine("HelloWorld");
            int i = 1;
            foreach (string arg in args)
            {
                Console.WriteLine("Arg[" + i++ + "]=" + arg);
            }
            Console.ReadLine();
        }
    }
}
