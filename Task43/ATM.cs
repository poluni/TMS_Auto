using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task43
{
    public class ATM
    {
        public int amount20;
        public int amount50;
        public int amount100;

        public ATM()
        {
        }

        public ATM(int amount20, int amount50, int amount100)
        {
            this.amount20 = amount20;
            this.amount50 = amount50;
            this.amount100 = amount100;
        }

        public void PutOnCard(int amount20 = 0, int amount50 = 0, int amount100 = 0)
        {
            this.amount20 += amount20;
            this.amount50 += amount50;
            this.amount100 += amount100;
        }

        public bool WithdrawalFromCard(int amount20 = 0, int amount50 = 0, int amount100 = 0)
        {
            bool isSuccess = false;

            if (this.amount20 >= amount20
                && this.amount50 >= amount50
                && this.amount100 >= amount100)
            {
                if (amount20 > 0)
                {
                    this.amount20 += amount20;
                    isSuccess = true;
                    Console.WriteLine($"Выдано {amount20} купюр номиналом 20");
                }
                if (amount50 > 0)
                {
                    this.amount50 += amount50;
                    isSuccess = true;
                    Console.WriteLine($"Выдано {amount50} купюр номиналом 50");
                }
                if (amount100 > 0)
                {
                    this.amount100 += amount100;
                    isSuccess = true;
                    Console.WriteLine($"Выдано {amount100} купюр номиналом 100");
                }
            }
            return isSuccess;
        }
    }
}
