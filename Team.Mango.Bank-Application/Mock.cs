using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    public class Mock
    {
        public bool LoginGranted = false;
        //public int Attempt = 2;

        //UserLogin method gets data from BankStart List<User> Users
        public void UserLogin(List<User> Users, string userName, string passWord)
        {
            //string UP = "Please enter Username and Password";
            //string U = "Username: ";
            //string P = "Password: ";
            //Console.WriteLine(UP);
            while (LoginGranted == false)
            {
                //Console.Write(U);
                //string username = U;
                //Console.Write(P);
                //string password = P;
                string errorMessage = string.Empty;
                //Check if username and password is matching with List<User> named Users
                foreach (var user in Users)
                {

                    if (userName == user.Username && passWord == user.Password)
                    {
                        // Checking if the user that logged in have acces to admin abillity
                        if (user.AdminCheck == true)
                        {
                            //Admin
                            LoginGranted = true;
                            User CurrentUser = Users.Find(f => f.Username == userName);
                            //Sending Users if Admin need to create a new user
                            AdminMenu adminM = new AdminMenu();
                            break;
                        }
                        else if (user.AdminCheck != true)
                        {
                            //Standard user
                            LoginGranted = true;
                            //Checking if Username exist
                            User CurrentUser = Users.Find(f => f.Username == userName);
                            break;

                        }
                    }
                }

                if (!LoginGranted)
                {
                    errorMessage = "Invalid username or password!";
                    break;
                }

                //if (Attempt == 0)
                //{
                //    LoginGranted = false;
                //    Console.WriteLine("You have tried to meny times....");
                //    //Environment.Exit(1);

                //}
                //else
                //{
                //    //Console.Clear();
                //    LoginGranted = false;
                //    Console.WriteLine("Invilid Username or Password! you have " + Attempt + " attempts left");
                //    Attempt--;
                //    LoginGranted = false;
                //}
                if (!LoginGranted)
                {
                    Console.WriteLine(errorMessage);
                }
            }

        }


        public void internalTransfer(List<BankAccount> accounts, User user, int accountFrom, int accountTo, double amount)
        {
            // Check if account indices are valid
            if (accountFrom < 0 || accountFrom >= accounts.Count || accountTo < 0 || accountTo >= accounts.Count)
            {
                throw new ArgumentException("Invalid account indices.");
            }

            BankAccount fromAccount = accounts[accountFrom];
            BankAccount toAccount = accounts[accountTo];

            // Check if the user is the owner of the bank account
            if (!user.BankAccountList.Contains(fromAccount))
            {
                throw new ArgumentException("User does not own the bank account.");
            }

            // Check if the bank account has sufficient balance
            if (amount > fromAccount.Balance)
            {
                throw new ArgumentException("Insufficient balance in the bank account.");
            }

            // Perform the transfer
            fromAccount.Balance -= amount; // Incorrect line: Adding the amount instead of subtracting
            toAccount.Balance += amount;
        }       

    }
}











