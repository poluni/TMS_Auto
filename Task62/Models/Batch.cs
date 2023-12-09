using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task62.Models
{
    internal class Batch : Product
    {
        public Batch(string name, decimal price, DateTime productionDate, DateTime expirationDate)
        {
            Name = name;
            Price = price;
            ProductionDate = productionDate;
            ExpirationDate = expirationDate;
        }

        public Batch(string name, decimal price, int quantity, DateTime productionDate, DateTime expirationDate) : this(name, price, productionDate, expirationDate)
        {
            Quantity = quantity;
        }

        public override string Name { get; set; }

        public override decimal Price { get; set; }

        public int Quantity { get; set; }

        public DateTime ProductionDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public override void PrintProductInfo()
        {
            Console.WriteLine($"{Name} {Price} {Quantity} {ProductionDate} {ExpirationDate}");
        }
    }
}
