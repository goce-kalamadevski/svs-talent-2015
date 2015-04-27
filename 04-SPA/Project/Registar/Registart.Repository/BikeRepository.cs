using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.DataLayer;
using Registar.Repository.Interfaces;

namespace Registar.Repository
{
    internal class BikeRepository:IBikeRepository
    {
        public IList<DomainModel.Bike> SearchBikes()
        {
            using (var context =  DataContextManager.CreateContext<IRegistarContext>())
            {
            }
        }
    }
}
