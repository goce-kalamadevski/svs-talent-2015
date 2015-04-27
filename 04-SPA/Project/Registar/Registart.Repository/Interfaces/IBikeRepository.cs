﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.Common.Interfaces;
using Registar.DomainModel;

namespace Registar.Repository.Interfaces
{
    public interface IBikeRepository:IRepository
    {
        IList<Bike> SearchBikes();
    }
}
