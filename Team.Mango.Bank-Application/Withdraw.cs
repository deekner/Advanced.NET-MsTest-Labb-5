using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    public class Withdraw : Menu
    {
        public double accountBalance { get; set; }

        public Withdraw()
        {
            
        }

        public void withdraw(List<BankAccount> accounts, User user, double amount)
        {
            if (amount > accounts[0].Balance)
            {
                Console.WriteLine("You can't withdraw more money than the account's balance");
            }
            else
            {
                accounts[0].Balance -= amount;
            }
        }
    }
}