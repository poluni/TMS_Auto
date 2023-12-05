using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task53.Models
{
    internal class Tramcar : Transport
    {
        public override string GetTransportType()
        {
            return "Rail";
        }
    }
}
