using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task53.Models
{
    internal class Bus : Transport
    {
        public string Destination { get; set; }

        public string BusNumber { get; set; }

        public DateTime DepartureTime { get; set; }

        public int SeatsNumber { get; set; }

        public override string GetTransportType()
        {
            return "Gasoline";
        }
    }
}
