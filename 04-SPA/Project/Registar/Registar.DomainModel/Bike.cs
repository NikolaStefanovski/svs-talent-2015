using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.DomainModel
{
    public class Bike
    {
        public int BikeId { get; set; }

        public string Model { get; set; }

        [NotMapped]
        public object IgnoreMe { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }
    }
}
