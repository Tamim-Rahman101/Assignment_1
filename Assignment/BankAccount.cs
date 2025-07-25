using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BankAccount
    {
        private double Balance;

        public BankAccount()
        {
            Balance = 0;
            Console.WriteLine("New account created with initial balance " + Balance);
        }
        public void Deposite(double amount)
        {
            if(amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount} is deposited. New balance is {Balance}");
            }
        }
        public void Withdraw(double amount)
        {
            if(Balance -  amount >= 0)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} is withdrawn. New balance is {Balance}");
            }
        }
    }
}