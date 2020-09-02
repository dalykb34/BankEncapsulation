using System;
using System.Collections.Generic;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var userData = new PersonalInformation();
            Console.WriteLine($"What is your first name?");
            var firstName = (Console.ReadLine());
            
            Console.WriteLine($"What is your last name?");
            var lastName = (Console.ReadLine());

            Console.WriteLine($"What is you Address?");
            var address = (Console.ReadLine());

            Console.WriteLine($"What city do you live in?");
            var city = (Console.ReadLine());

            Console.WriteLine($"What state do you live in?");
            var state = (Console.ReadLine());

            Console.WriteLine($"What is the zipcode?");
            var zipCode = (Console.ReadLine());

            Console.WriteLine($"What is your phone number starting with area code?");
            userData.NumberFormatted = Console.ReadLine();
            Console.WriteLine($"Your phone number is {userData.NumberFormatted}");
            
            var account = new BankAccount();
            Console.WriteLine($"how much would you like to deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());
            account.Deposit(amountToDeposit);
            Console.WriteLine($"Current balance is: ${account.GetBalance()}");
            
            Console.WriteLine($"How much would you like to withdraw?");
            double.Parse(Console.ReadLine());
            account.Withdraw( ) ;
        }
    
}
