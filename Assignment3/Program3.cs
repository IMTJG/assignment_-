using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CS110 BANK ");
            Console.WriteLine("What is your bank id? 45678");
            Console.WriteLine("Initial deposit into Checking: 900");
            Console.WriteLine("Initial deposit into Saving: 3000");
            BankAccount myAccount = new BankAccount("45678", 900, 3000);
            String id;
            bool flag = true;
            double deposit_money, withdraw_money;
            Console.WriteLine("Command Options");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("a: deposit");
            Console.WriteLine("b: withdraw");
            Console.WriteLine("c: display the balance ");
            Console.WriteLine("d: Check the account");
            Console.WriteLine("?: display the menu again ");
            Console.WriteLine("q: quit this program");
            while (flag)
            {
                Console.WriteLine("Please enter a command or type ? ");
                String choice = Console.ReadLine();
                switch (choice)
                {
                    case "a":
                        {
                            Console.WriteLine("Amount to deposit: ");
                            deposit_money = Convert.ToDouble(Console.ReadLine());
                            myAccount.deposit(deposit_money);
                            Console.Write("You deposited $");
                            Console.Write(deposit_money);
                            Console.WriteLine(" to Checking.");
                            break;
                        }
                    case "b":
                        {
                            Console.WriteLine("Amount to withdraw: ");
                            withdraw_money = Convert.ToDouble(Console.ReadLine());
                            if (withdraw_money > myAccount.getChecking())
                            {
                                Console.WriteLine("Invalid choice (not sufficient fund)");
                                break;
                            }
                            myAccount.withdraw(withdraw_money);
                            Console.Write("You withdrew $");
                            Console.WriteLine(withdraw_money);
                            break;
                        }
                    case "c":
                        {
                            Console.WriteLine(myAccount.toString());
                            break;
                        }
                    case "d":
                        {
                            Console.Write("What is your bank id?");
                            id = Console.ReadLine();
                            if (myAccount.getID() != id)
                            {
                                Console.WriteLine("Wrong ID!");
                                break;
                            }
                            Console.Write("Here is the balance: ID: ");
                            Console.WriteLine(myAccount.getID());
                            Console.Write("Checking Balance: $");
                            Console.WriteLine(myAccount.getChecking().ToString("0.00"));
                            Console.Write("Saving Balance: $");
                            Console.WriteLine(myAccount.getSaving().ToString("0.00"));
                            break;
                        }
                    case "?":
                        {
                            Console.WriteLine("Command Options");
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine("a: deposit");
                            Console.WriteLine("b: withdraw");
                            Console.WriteLine("c: display the balance ");
                            Console.WriteLine("d: Check the account");
                            Console.WriteLine("?: display the menu again ");
                            Console.WriteLine("q: quit this program");
                            break;
                        }
                    case "q":
                        {
                            myAccount.addInterest();
                            Console.WriteLine(myAccount.toString());
                            flag = false;
                            break;
                        }
                    default: { Console.WriteLine("error!"); break; }
                }
            }
        }
    }
}
