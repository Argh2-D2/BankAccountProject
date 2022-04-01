using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    class CheckingAccount : Account
    {
        //Checks will go here (Withdrawal Method)

        // Fields 

        private int checkingAccountNumber;
        private double checkingAccountBalance;


        //Properties

        public int CheckingAccountNumber
        {
            get { return this.checkingAccountNumber; }
            set { this.checkingAccountNumber = value; }
        }
        public double CheckingAccountBalance
        {
            get { return this.checkingAccountBalance; }
            set { this.checkingAccountBalance = value; }
        }


        //Constructors
        public CheckingAccount()
        {

            this.checkingAccountNumber = 234567;
            this.checkingAccountBalance = 5000;

        }

        //Methods

        public void WriteCheck()
        {
            Console.WriteLine("What is the check number you want to write?");
            int checkNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much is the check in dollars and cents?");
            double checkAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thank you. You have withdrawn check number " + checkNumber + " in the amount of -" + checkAmount + " on " + DateTime.Now);
            checkingAccountBalance = checkingAccountBalance - checkAmount;
            Console.WriteLine("Your total available balance is: " + checkingAccountBalance);

        }

        public void PrintCheckingStats()
        {
            Console.WriteLine("Checking Balance: " + this.checkingAccountBalance);

        }





    }
}