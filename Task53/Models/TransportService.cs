using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task53.Models
{
    internal class TransportService
    {
        public void PrintTransportService(Transport transport) 
        {
             Console.WriteLine(transport.GetTransportType()); 
        }
    }
}
