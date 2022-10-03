using System;
using System.Diagnostics;

namespace ATM
{
    class Program
    {
        static public void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("[1] Deposit");
            Console.WriteLine("[2] Withdraw");
            Console.WriteLine("[3] Show Balance");
            Console.WriteLine("[4] Exit");
        }

        static void Main()
        {
            List<cardHolder> cardHolders = new List<cardHolder>();
            cardHolders.Add(new cardHolder("123", 1234, "John", "Griffith", 150.31));
            cardHolders.Add(new cardHolder("1234", 4321, "Ashley", "Jones", 321.13));
            cardHolders.Add(new cardHolder("12345", 9999, "Frida", "Dickerson", 105.49));
            cardHolders.Add(new cardHolder("123456", 2468, "Muneeb", "Harding", 851.84));
            cardHolders.Add(new cardHolder("1234567", 4826, "Dawn", "Smith", 54.27));

            Console.WriteLine("Welcome to SimpleATM");
            Console.WriteLine("Please insert your debit card: ");
            string debitCardNum = "";
            cardHolder currentUser;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    // Check against our db
                    currentUser = cardHolders.FirstOrDefault(a => a.CardNum == debitCardNum);
                    if (currentUser != null) { break; }
                    else { Console.WriteLine("Card not recognized. Please try again"); }
                }
                catch
                {
                    Console.WriteLine("Card not recognized. Please try again");
                }
            }
            Console.WriteLine("Please enter your pin: ");
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    currentUser = cardHolders.FirstOrDefault(a => a.Pin == userPin);
                    if (currentUser != null) { break; }
                    else { Console.WriteLine("Incorrect pin. Please try again."); }
                }
                catch
                {
                    Console.WriteLine("Incorrect pin. Please try again");
                }
            }
            Console.WriteLine("Welcome " + currentUser.FirstName + " :)");
            int opt = 0;
            do
            {
                printOptions();
                try
                {
                    opt = int.Parse(Console.ReadLine());
                }
                catch { }
                if (opt == 1) { Procedures.deposit(currentUser); }
                else if (opt == 2) { Procedures.withdraw(currentUser); }
                else if (opt == 3) { Procedures.balance(currentUser); }
                else if (opt == 4) { break; }
                else { opt = 0; }
            } while (opt != 4);
            Console.WriteLine("Thank you! Have a nice day :)");
        }
    }
}