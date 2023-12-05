using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task53.Models
{
    internal class Transport : PublicTransportPark
    {
        private string[] transportTypes = new string[]{ "Electric", "Rail", "Gasoline" };

        public virtual string GetTransportType()
        {
            return "";
        }

        protected sealed override string AddNewTransportType(string transportType)
        {
            return "";
        }
    }
}
