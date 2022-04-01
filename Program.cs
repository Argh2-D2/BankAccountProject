using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {   

            double totalBalance = 0.0d;
            double checkingBalance = 0.0d;
            double reserveBalance = 0.0d;
            double savingsBalance = 0.0d;
            totalBalance = (checkingBalance + reserveBalance + savingsBalance);
            string clientInput = "0";


            Account JordanJames = new Account();
            CheckingAccount checkingUser = new CheckingAccount();


            StringBuilder mainMenu = new StringBuilder();
            mainMenu.Append("OurBank Main Menu\n");
            mainMenu.Append("View Client Information, Press '1'\n");
            mainMenu.Append("View Account Balance Information, Press '2'\n");
            mainMenu.Append("To Deposit Funds, Press '3'\n");
            mainMenu.Append("To Withdraw Funds, Press '4'\n");
            mainMenu.Append("To Exit the Application, Press '5'\n");
            mainMenu.Append("Thank you for being a valued OurBank customer!\n");
            mainMenu.Append("Today's Date and time is: " + DateTime.Now + "\n");
            Console.WriteLine(mainMenu.ToString());
            clientInput = Console.ReadLine();
            if (clientInput == "1")
            {
                JordanJames.PrintClientInfo();
            }
            else if (clientInput == "2")
            {
                JordanJames.PrintStats();
            }
            else if (clientInput == "3")
            {
                JordanJames.PrintStats();
                JordanJames.Deposit();

            }
            else if (clientInput == "4")
            {
                Console.Clear();
                Console.WriteLine("Do you want to write a check (1), or withdrawl from savings (2)?");
                int userResponse = Convert.ToInt32(Console.ReadLine());
                if (userResponse == 1)
                    checkingUser.WriteCheck();
                else
                    JordanJames.Withdrawl();
            }
            Console.ReadKey();

            StreamWriter checkingWriter = new StreamWriter("checking.txt");
            using (checkingWriter)
            {
                checkingWriter.Write("Hekki Wirld");
            }
            StreamWriter savingsWriter = new StreamWriter("savings.txt");
            using (savingsWriter)
            {
                savingsWriter.Write(DateTime.Now);
            }
            StreamWriter reserveWriter = new StreamWriter("reserve.txt");
            using (reserveWriter)
            {
                reserveWriter.Write(DateTime.Now);
            }
        }


    }
}