using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task53.Models
{
    abstract class PublicTransport : Transport
    { 
        protected sealed override void AddNewTransportType(string transportType) { }
    }
}
