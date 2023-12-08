using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task53.Models
{
    internal class Tramcar : Transport
    {
        public Tramcar(string destination, string tramNumber, DateTime departureTime, int seatsNumber)
        {
            this.Destination = destination;
            this.TramNumber = tramNumber;
            this.DepartureTime = departureTime;
            this.SeatsNumber = seatsNumber;
        }

        public string Destination { get; set; }        

        public string TramNumber { get; set; }

        public DateTime DepartureTime { get; set; }

        public int SeatsNumber { get; set; }

        public override string GetTransportType() => "Rail";

        public override string GetTransportName() => "Трамвай";

        public override int GetSeatsNumber() => SeatsNumber;

        public override string GetDestination() => Destination;

        public override DateTime GetDepartureTime() => DepartureTime;

    }
}
