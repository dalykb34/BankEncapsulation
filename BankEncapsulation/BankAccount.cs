using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;
        public BankAccount()
        {
        }
        public void  Deposit(double value)
        {
            balance += value;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void Withdraw()
        {
            double withdrawlAmount;
            bool isNumber;
            do
            {
                Console.WriteLine($"Account Balance: {balance,0:c}");
                Console.WriteLine($"How much do you want to withdraw?");
                var userResponse = Console.ReadLine();
                isNumber = double.TryParse(userResponse, out withdrawlAmount);

                while (withdrawlAmount > balance)
                {
                    Console.WriteLine($"Not enough funds. Please enter an appropriate amount:");
                    userResponse = Console.ReadLine();
                    isNumber = double.TryParse(userResponse, out withdrawlAmount);
                }

            } while (isNumber == false);
            balance -= withdrawlAmount;
            Console.WriteLine($"{withdrawlAmount,0:c} was taken from your account. Current balance: {balance,0:c}");
        }
        

    }

}
