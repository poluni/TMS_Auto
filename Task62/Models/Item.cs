using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task62.Models
{
    internal class Item : Batch
    {
        public Item(string name, decimal price, DateTime productionDate, DateTime expirationDate) : base(name, price, productionDate, expirationDate)
        {
        }

        public override void PrintProductInfo()
        {
            Console.Write($"Наименование {Name}, ");
            Console.Write("Цена {0:c2}, ", Price);
            Console.Write(string.Format("Дата производства {0}, ", ProductionDate.ToString("yyyy.MM.dd")));
            Console.Write(string.Format("Срок годности {0} ", ExpirationDate.ToString("yyyy.MM.dd")));
        }
    }
}
