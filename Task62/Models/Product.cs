using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task62.Models
{
    internal abstract class Product : IValidable
    {
        public abstract string Name { get; set; }

        public abstract decimal Price { get; set; }

        public abstract void PrintProductInfo();

        public virtual bool IsValid(DateTime expiriationDate)
        {
            if (expiriationDate.CompareTo(DateTime.Today) >= 0) return true;
            else return false;
        }
    }
}
