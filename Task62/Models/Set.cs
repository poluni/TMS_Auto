using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task62.Models
{
    internal class Set : Product
    {
        public Set(string name, decimal price, Item[] item)
        {
            Name = name;
            Price = price;
            ItemList = new Item[] { };
        }

        public override string Name { get; set; }

        public override decimal Price { get; set; }

        public Item[] ItemList { get; set; }

        public override void PrintProductInfo()
        {
            Console.WriteLine($"{Name} {Price}");
        }
    }
}
