using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurWorld.Models
{
    public class Stop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitute { get; set; }
        public double Longitude { get; set; }
        public int Order { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}
