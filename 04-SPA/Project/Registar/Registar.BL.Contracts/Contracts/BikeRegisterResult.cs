using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BusinessLayer.Contracts;

namespace Registar.BL.Contracts.Contracts
{
    public class BikeRegisterResult:CommandResult
    {

        public bool IsSuccess { get; set; }

        public List<string> ValidationErrors { get; set; } 
    }
}
