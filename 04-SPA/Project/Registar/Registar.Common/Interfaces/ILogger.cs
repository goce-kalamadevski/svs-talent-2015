using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Common.Interfaces
{
    public interface ILogger
    {
        void LogError(string message, Exception e);

        void LogWarning(string message);
    }
}
