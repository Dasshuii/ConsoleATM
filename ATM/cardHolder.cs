using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class cardHolder
    {
        private string cardNum;
        private int pin;
        private string firstName;
        private string lastName;
        private double balance;

        public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }
        public string CardNum
        {
            get { return cardNum; }
            set { cardNum = value; }
        }
        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
