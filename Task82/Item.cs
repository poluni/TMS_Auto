using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task82
{
    internal class Item
    {
        public string Title { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public Item() { }

        public Item(string title, decimal price, int quantity)
        {
            Title = title;
            Price = price;
            Quantity = quantity;
        }        
    }
}
