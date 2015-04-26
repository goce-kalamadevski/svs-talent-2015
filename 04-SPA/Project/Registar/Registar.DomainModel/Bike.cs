using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DomainModel
{
    /// <summary>
    /// Domain model object for Bike
    /// </summary>
    public class Bike
    {
        //[Key]
        public int BikeId { get; set; }

        public string RegNumber { get; set; }

        public string Producer { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }

        [NotMapped]
        public object IgnoreMe { get; set; }

        [NotMapped]
        [Timestamp]
        public byte[] TimeStamp { get; set; }

        
        public IEnumerable<BikeHistory> History { get; set; } 
    }

    public class BikeHistory
    {
        public int BikeId { get; set; }

        public DateTime Date { get; set; }
    }
}
