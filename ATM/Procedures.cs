using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Procedures
    {
        static public void deposit(cardHolder currentUser)
        {
            double deposit = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("How much $$ would you like to deposit?");
                    deposit = Double.Parse(Console.ReadLine());
                    if (deposit < 0)
                    {
                        throw new ArgumentException();
                    } else
                    {
                        break;
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            currentUser.Balance += deposit;
            Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.Balance);
        }
        static public void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            //Check if the user has enough money
            if(currentUser.Balance < withdrawal)
            {
                Console.WriteLine("Insufficient balance :(");
            }
            else
            {
                currentUser.Balance = currentUser.Balance - withdrawal;
                Console.WriteLine("You're good to go! Thank you :)");
            }
        }

        static public void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.Balance);
        }
    }
}
