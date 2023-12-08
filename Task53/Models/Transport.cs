using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task53.Models
{
    abstract class Transport : PublicTransportPark
    {
        public abstract string GetTransportType();

        public abstract string GetTransportName();

        public abstract int GetSeatsNumber();

        public abstract string GetDestination();

        public abstract DateTime GetDepartureTime();

        protected sealed override string AddNewTransportType(string transportType) => String.Empty;
    }
}
