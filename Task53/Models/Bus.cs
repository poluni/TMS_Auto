namespace Task53.Models
{
    internal class Bus : PublicTransport
    {
        public Bus(string destination, string busNumber, DateTime departureTime, int seatsNumber) 
        {
            Destination = destination;
            Number = busNumber;
            this.DepartureTime = departureTime;
            this.SeatsNumber = seatsNumber;
        }        

        public string Destination { get; set; }

        public string Number { get; set; }

        public DateTime DepartureTime { get; set; }

        public int SeatsNumber { get; set; }

        public override string GetTransportType() => "Gasoline";

        public override string GetTransportName() => "Автобус";

        public override int GetSeatsNumber() => SeatsNumber;

        public override string GetDestination() => Destination;

        public override DateTime GetDepartureTime() => DepartureTime;
    }
}
