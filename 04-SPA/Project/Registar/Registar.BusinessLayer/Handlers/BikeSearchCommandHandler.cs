using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BusinessLayer.Contracts;
using Registar.Common;
using Registar.DataLayer;
using Registar.DomainModel;
using Registar.Repository.Interfaces;

namespace Registar.BusinessLayer.Handlers
{
    internal class BikeSearchCommandHandler:CommandHandlerBase<BikeSearchCommand,BikeSearchResult>
    {
        protected override BikeSearchResult ExecuteCommand(BikeSearchCommand command)
        {
            IBikeRepository repo = RepositoryManager.CreateRepository<IBikeRepository>();
            IUserRepository usrRepo = RepositoryManager.CreateRepository<IUserRepository>();

            BikeSearchResult result = new BikeSearchResult();
            result.Result = repo.SearchBikes() as List<Bike>;
            //
            return result;
        }
    }
}
