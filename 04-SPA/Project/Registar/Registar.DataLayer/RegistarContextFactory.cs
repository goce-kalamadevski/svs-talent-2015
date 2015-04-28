using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.Common.Interfaces;

namespace Registar.DataLayer
{
    public class RegistarContextFactory:IContextFactory
    {
        public TContext CreateContext<TContext>()
        {
            return (TContext) (object)new RegistarDbContext();
        }
    }
}
