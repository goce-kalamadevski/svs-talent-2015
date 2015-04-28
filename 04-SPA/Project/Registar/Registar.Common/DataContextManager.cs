using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Registar.Common.Interfaces;

namespace Registar.Common
{
    public static class DataContextManager
    {
        private static IContextFactory theFactory;

        public static TContext CreateContext<TContext>()
        {
            return theFactory.CreateContext<TContext>();
        }

        public static void RegisterContextFactory(IContextFactory factory)
        {
            theFactory = factory;
        }
    }
}
