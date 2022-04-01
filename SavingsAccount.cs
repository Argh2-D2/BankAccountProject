using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class SavingsAccount : Account
    {
        private int savingsAccountNumber;
        private double savingsAccountBalance;


        //Properties

        public int SavingsAccountNumber
        {
            get { return this.savingsAccountNumber; }
            set { this.savingsAccountNumber = value; }
        }
        public double SavingsAccountBalance
        {
            get { return this.savingsAccountBalance; }
            set { this.savingsAccountBalance = value; }
        }


        //Constructors
        public SavingsAccount()
        {

            this.savingsAccountNumber = 345678;
            this.savingsAccountBalance = 8000;

        }

        //Methods

        public void AddInterest()
        {
            Console.WriteLine("Today is your lucky day! We are adding interest today.");
            double interestRate = .05;
            double interestAdded = savingsAccountBalance * interestRate;
            savingsAccountBalance = interestAdded + savingsAccountBalance;
            Console.WriteLine("Thank you. You have earned interest in the amount of +" + interestAdded + " on " + DateTime.Now);
            Console.WriteLine("Your total available balance is: " + savingsAccountBalance);

        }

        public void PrintSavingsStats()
        {
            Console.WriteLine("Savings Balance: " + this.savingsAccountBalance);

        }

    }
}