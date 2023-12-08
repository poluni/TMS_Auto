using System.Globalization;
using Task53.Models;

namespace Task53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new("Ул Ленина", "d85cd", new DateTime(2023, 06, 12, 18, 30, 25), 43);
            Console.WriteLine($"Номер автобуса: {bus.Number}");
            Console.WriteLine($"Пункт назначения: {bus.Destination}");
            Console.WriteLine($"Время отправления: {bus.DepartureTime}");
            Console.WriteLine($"Количество мест: {bus.SeatsNumber}");

            Transport[] transports =
            {
                new Bus("95-ый квартал", "er6123u", new DateTime(2023, 07, 12, 19, 22, 22), 26),
                new Tramcar("Левино поле", "io459u", new DateTime(2023, 08, 12, 20, 23, 23), 36),
                new Trolleybus("Военный городок", "vb783y", new DateTime(2023, 09, 12, 21, 24, 24), 20),
            };

            //Сортировка массива транспорта по числу мест
            Console.WriteLine();

            foreach (var transport in transports)
            {
                Console.WriteLine(string.Concat(transport.GetTransportName(), " - ", transport.GetSeatsNumber()));
            }

            var sortedTransports = transports.OrderBy(x => x.GetSeatsNumber());
            foreach (var transport in sortedTransports)
            {
                Console.WriteLine(string.Concat(transport.GetTransportName(), " - ", transport.GetSeatsNumber()));
            }

            //Поиск по точному совпадению по одному из двух или двум параметрам

            Console.Write("Введите пункт назначения для поиска: ");
            string? destinationSearch = Console.ReadLine().Trim().ToString();
            Console.Write("Введите дату отправления для поиска: ");
            string? departureTimeUser = Console.ReadLine().Trim();
            DateTime departureTimeSearch;
            bool isParsed = DateTime.TryParse(departureTimeUser, out departureTimeSearch);

            if (!string.IsNullOrEmpty(destinationSearch) || isParsed)
            {
                foreach (var transport in transports)
                {
                    if (isParsed)
                    {
                        int res = DateTime.Compare(departureTimeSearch, transport.GetDepartureTime());
                        if (res == 0)
                        {
                            Console.WriteLine(string.Concat(transport.GetTransportName(), " в ", transport.GetDepartureTime().ToString()));
                        }
                        else if (destinationSearch.Equals(transport.GetDestination())
                            && DateTime.Compare(departureTimeSearch, transport.GetDepartureTime()) == 0)
                        {
                            Console.WriteLine(string.Concat(transport.GetTransportName(), " в ", transport.GetDepartureTime().ToString()));
                        }
                    } else if (destinationSearch.Equals(transport.GetDestination()))
                    {
                        Console.WriteLine(string.Concat(transport.GetTransportName(), " в ", transport.GetDestination()));
                    }
                }
            }
            else Console.WriteLine("Не найдено");

            //Поиск по одному параметру (Время отправления)

            Console.Write("Введите дату отправления для поиска: ");
            string? departureTimeUser1 = Console.ReadLine().Trim();
            DateTime departureTimeSearch1;
            bool isParsed1 = DateTime.TryParse(departureTimeUser1, out departureTimeSearch1);

            if (!string.IsNullOrEmpty(departureTimeUser1) || isParsed1)
            {
                Console.WriteLine("Время отправления позже, введенного пользователем ");
                foreach (var transport in transports)
                {
                    int result = DateTime.Compare(departureTimeSearch, transport.GetDepartureTime());
                    if (result < 0) Console.WriteLine(transport.GetDepartureTime());
                }
            }
            else Console.WriteLine("Повторите ввод.");

            //Печать типа транспорта

            TransportService service = new TransportService();
            service.PrintTransportService(transports[0]);
            service.PrintTransportService(transports[1]);
            service.PrintTransportService(transports[2]);
        }
    }
}
