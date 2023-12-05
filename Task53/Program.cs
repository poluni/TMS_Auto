using Task53.Models;

namespace Task53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new();
            Console.WriteLine(bus.BusNumber);
            Console.WriteLine(bus.Destination);
            Console.WriteLine(bus.DepartureTime);
            Console.WriteLine(bus.SeatsNumber);

            Tramcar tramcar = new();
            Trolleybus trolleybus = new();

            TransportService service = new TransportService();              
            service.PrintTransportService(tramcar);
            service.PrintTransportService(trolleybus);
            service.PrintTransportService(bus);


        }
    }
}
