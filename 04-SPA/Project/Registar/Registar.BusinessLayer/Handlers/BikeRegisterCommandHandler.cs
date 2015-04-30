using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BL.Contracts.Contracts;
using Registar.Common;
using Registar.Repository.Interfaces;

namespace Registar.BusinessLayer.Handlers
{
    public class BikeRegisterCommandHandler:CommandHandlerBase<BikeRegisterCommand, BikeRegisterResult>
    {
        protected override BikeRegisterResult ExecuteCommand(BikeRegisterCommand command)
        {
            BikeRegisterResult result = new BikeRegisterResult();
            result.IsSuccess = false;
            result.ValidationErrors = new List<string>();
            result.ValidationErrors.Add("Not valid ownerid!");

            IBikeRepository bikeRepo = RepositoryManager.CreateRepository<IBikeRepository>();
            //
            bikeRepo.SaveBike(command.BikeToRegister);
            //
            return result;
        }
    }
}
