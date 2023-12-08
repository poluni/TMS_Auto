using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task53.Models
{
    internal class Trolleybus : Transport
    {
        public Trolleybus(string destination, string trolleybusNumber, DateTime departureTime, int seatsNumber)
        {
            this.Destination = destination;
            this.TrolleybusNumber = trolleybusNumber;
            this.DepartureTime = departureTime;
            this.SeatsNumber = seatsNumber;
        }

        public string Destination { get; set; }

        public string TrolleybusNumber { get; set; }

        public DateTime DepartureTime { get; set; }

        public int SeatsNumber { get; set; }

        public override string GetTransportType() => "Electric";

        public override string GetTransportName() => "Троллейбус";

        public override int GetSeatsNumber() => SeatsNumber;

        public override string GetDestination() => Destination;

        public override DateTime GetDepartureTime() => DepartureTime;
    }
}
