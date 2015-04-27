using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.Common.Interfaces;

namespace Registar.Repository.Interfaces
{
    public interface IUserRepository:IRepository
    {
        bool UpdateProfileData();
    }
}
