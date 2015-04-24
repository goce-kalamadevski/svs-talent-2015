using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registar.Models
{
    /// <summary>
    /// Model class for bike
    /// </summary>
    public class BikeModel
    {
        public string RegNumber { get; set; }

        public string Producer { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }
    }
}