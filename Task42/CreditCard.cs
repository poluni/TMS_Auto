using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task42
{
    public class CreditCard
    {
        public string accountNumber;
        public decimal balance;

        public CreditCard()
        {
        }

        public CreditCard(string accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void PutOnAccountNumber(decimal amount) => balance += amount;

        public void WithdrawalFromAccountNumber(decimal amount)
        {
            if (balance >= amount) balance -= amount;
            else Console.WriteLine($"На счете {accountNumber} не хватает средств");
        }

        public void ShowBalance() => Console.WriteLine(
            string.Format("Баланс на счете {0}: {1:C2}",
            accountNumber, balance));
    }
}
