using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.DomainModel;

namespace Registar.DataLayer
{
    public class BikeConfiguration 
        : EntityTypeConfiguration<Bike>
    {
        public BikeConfiguration()
        {
            this.ToTable("Bikes", "Data")
                //.HasKey(x => new {Id = x.BikeId, Colour = x.Colour});
                .HasKey(p => p.BikeId);

            this.Property(p => p.BikeId)
                .HasColumnName("BikeId");

            //this.Ignore(p => p.IgnoreMe);
        }
    }
}
