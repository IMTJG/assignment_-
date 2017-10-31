using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class BankAccount{
                private String Id;
                private double checking_balance;
                private double saving_balance;
                public BankAccount()
                {
                    double checking_balance=0;
                    double saving_balance=0;
                }
                public BankAccount(String initID, double initChecking, double initSaving)
                {
                    Id = initID;
                    checking_balance = initChecking;
                    saving_balance = initSaving;
                }
                public String getID()
                {
                    return Id;
                }
                public double getChecking()
                {
                    return checking_balance;
                }
                public double getSaving()
                {
                    return saving_balance;
                }
                public double getBalance()
                {
                    return checking_balance+saving_balance;
                }
                public void setID(String name)
                {
                    Id = name;
                }
                public void deposit(double depositAmount){
                    checking_balance+=depositAmount;
                }
                public bool withdraw(double withdrawAmount)
                {
                    if (withdrawAmount >= 0 && withdrawAmount <= checking_balance)
                    {
                        checking_balance -= withdrawAmount;
                        return true;
                    }
                    return false;
                }
                public void addInterest()
                {
                    if (checking_balance <= 1000)
                        checking_balance *= (1 + 0.025);
                    if (checking_balance > 1000 && checking_balance < 5000)
                        checking_balance *= (1 + 0.035);
                    if (checking_balance >= 5000)
                        checking_balance *= (1 + 0.045);
                    if (saving_balance <= 1000)
                        saving_balance *= (1 + 0.025);
                    if (saving_balance > 1000 && saving_balance < 5000)
                        saving_balance *= (1 + 0.035);
                    if (saving_balance >= 5000)
                        saving_balance *= (1 + 0.045);
                }
                public bool equals(String s)
                {
                    if (Id == s) return true;
                    else return false;
                }
                public String toString()
                {
                    return "ID: " + Id +System.Environment.NewLine+ 
                           "Checking Balance: $" + checking_balance.ToString("0.00") +System.Environment.NewLine + 
                           "Saving Balance: $" + saving_balance.ToString("0.00");
                }
            }
}
