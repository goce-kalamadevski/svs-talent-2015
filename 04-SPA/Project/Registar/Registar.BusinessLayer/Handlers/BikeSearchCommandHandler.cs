using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BusinessLayer.Contracts;

namespace Registar.BusinessLayer.Handlers
{
    internal class BikeSearchCommandHandler:CommandHandlerBase<BikeSearchCommand,BikeSearchResult>
    {
        protected override BikeSearchResult ExecuteCommand(BikeSearchCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
