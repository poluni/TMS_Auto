using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task41
{
    public class Phone
    {
        public string number;
        public string model;
        public int weight;

        public Phone()
        {
        }

        public Phone(string number, string model)
        {
            this.number = number;
            this.model = model;
        }

        public Phone(string number, string model, int weight) : this(number, model)
        {
            this.weight = weight;
        }

        public void receiveCall(string name) => Console.WriteLine($"Звонит {name}");

        public string getNumber()
        {
            return this.number;
        }

        public void sendMessage(params string[] numbers)
        {
            foreach (string number in numbers)
            {
                Console.WriteLine($"Номер телефона: {number}");
            }
            Console.WriteLine();
        }
    }
}
