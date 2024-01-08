using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task72.Models
{
    internal class Item
    {
        public Item(string itemName)
        {
            ItemName = itemName;
        }

        public Item(int id, string itemName) : this(itemName)
        {
            ID = id;
        }

        public int ID { get; private set; } = new Random().Next(1, 500);

        public string ItemName { get; set; }
    }
}
