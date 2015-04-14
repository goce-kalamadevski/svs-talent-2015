using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Common
{
    /// <summary>
    /// Will be used for logging exceptions (Console.Output for now).
    /// </summary>
    public class ExceptionLogger
    {
        public static void Log(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
