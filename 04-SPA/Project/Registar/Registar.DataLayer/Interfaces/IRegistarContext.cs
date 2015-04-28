using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.DomainModel;

namespace Registar.DataLayer.Interfaces
{
    public interface IRegistarContext:IDisposable
    {
        IDbSet<Bike> Bikes { get; } 
    }
}
