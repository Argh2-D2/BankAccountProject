using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    public class Account
    {

        //The Account Number will go here
        //The Account Type will go here
        //The Date method will go here
        //The Transaction Methods will go here
        //  Deposits
        //  Withdrawls
        //  View
        //Current balance will go here

        //When the customer enters '2' on the main menu, it goes here


        //Fields
        protected string clientName;
        protected double accountBalance;
        protected int accountNumber;
        protected string address;


        private string CheckingAccountBalance;

        //Properties
        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = value; }
        }
        public double AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        //Constructors
        public Account()
        {
            this.clientName = "Jordan James";
            this.address = "123 Anywhere St., Boulder, CO 80906";
            this.accountBalance = 21434;
            this.accountNumber = 123456;



        }

        //Methods

        public void Deposit()
        {
            Console.WriteLine("How much are you depositing today, in dollars and cents?");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            accountBalance = accountBalance + depositAmount;
            Console.WriteLine("Thank you! Your deposit was + " + depositAmount + " and your new account balance is: " + accountBalance);

        }

        public void Withdrawl()
        {
            Console.WriteLine("How much are you withdrawaling today, in dollars and cents?");
            double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
            accountBalance = accountBalance - withdrawalAmount;
            Console.WriteLine("Thank you! Your withdrawal was - " + withdrawalAmount + " and your new account balance is: " + accountBalance);

        }

        public void PrintStats()
        {
            Console.WriteLine("Client Name: " + clientName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Balance: " + this.accountBalance);
            Console.WriteLine("Checking Account Balance: " + CheckingAccountBalance);

        }



        public void PrintClientInfo()
        {
            Console.WriteLine("Client Name: " + clientName);
            Console.WriteLine("Client Address: " + address);
        }


    }
}