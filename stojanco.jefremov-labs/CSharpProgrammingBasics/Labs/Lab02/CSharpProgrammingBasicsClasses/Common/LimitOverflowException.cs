using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Common
{
    /// <summary>
    /// When a transaction is initiated that will overflow the TransactionAccount limit throws this exception.
    /// </summary>
    public class LimitOverflowException:ApplicationException
    {
        /// <summary>
        /// Identifies the exception.
        /// </summary>
        public string ErrorCode
        {
            get;
            set;
        }
        public LimitOverflowException():base()
        {
            
        }
        public LimitOverflowException(string message):base(message)
        {

        }
    }
}
