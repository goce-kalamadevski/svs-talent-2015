using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.DomainModel;

namespace Registar.DataLayer
{
    public class RegistarDbContext : DbContext
    {
        public DbSet<Bike> Bikes { get; set; }

        public RegistarDbContext() : base("RegistarDb")
        {
            this.Bikes = this.Set<Bike>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BikeConfiguration());
            
        }
    }
}
