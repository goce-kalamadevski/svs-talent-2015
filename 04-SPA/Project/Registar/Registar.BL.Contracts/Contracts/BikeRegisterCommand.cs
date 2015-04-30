using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BusinessLayer.Contracts;
using Registar.DomainModel;

namespace Registar.BL.Contracts.Contracts
{
    public class BikeRegisterCommand:Command
    {
        public Bike BikeToRegister { get; set; }
    }
}
