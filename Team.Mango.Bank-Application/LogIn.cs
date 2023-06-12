using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{   // Login fuction and admin menu
    public class Login
    {
        public bool LoginGranted = false;
        public int Attempt = 2;

        //UserLogin method gets data from BankStart List<User> Users
        public void UserLogin(List<User> Users, CurrencyRates CurrRate)
        {
            string UP = "Please enter Username and Password";
            string U = "Username: ";
            string P = "Password: ";
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - UP.Length) / 2, Console.CursorTop);
            Console.WriteLine(UP);
            while (LoginGranted == false)
            {
                Console.SetCursorPosition((Console.WindowWidth - U.Length) / 2, Console.CursorTop);
                Console.Write(U);
                string username = Console.ReadLine();
                Console.SetCursorPosition((Console.WindowWidth - P.Length) / 2, Console.CursorTop);
                Console.Write(P);
                string password = Console.ReadLine();

                //Check if username and password is matching with List<User> named Users
                foreach (var user in Users)
                {

                    if (username == user.Username && password == user.Password)
                    {
                        // Checking if the user that logged in have acces to admin abillity
                        if (user.AdminCheck == true)
                        {
                            //Admin
                            LoginGranted = true;
                            User CurrentUser = Users.Find(f => f.Username == username);
                            //Sending Users if Admin need to create a new user
                            AdminMenu adminM = new AdminMenu();
                             adminM.adminMenu(Users, CurrentUser, CurrRate);




                        }
                        else if (user.AdminCheck != true)
                        {
                            //Standard user
                            LoginGranted = true;
                            //Checking if Username exist
                            User CurrentUser = Users.Find(f => f.Username == username);
                            Menu.MenuOptions(Users, CurrentUser, CurrRate);

                        }


                    }
                }
                if (Attempt == 0)
                {
                    LoginGranted = false;
                    Console.WriteLine("You have tried to meny times....");
                    Environment.Exit(1);
                }
                else
                {
                    Console.Clear();
                    LoginGranted = false;
                    Console.WriteLine("Invilid Username or Password! you have " + Attempt + " attempts left");
                    Attempt--;
                    LoginGranted = false;
                }
            }
        }



        // Moved this fuction to AdminMenu class
        ////ADMIN Menu
        //public void AdminMenu(List<User> Users, User CurrentUser)
        //{
        //    do
        //    {
        //        Console.Clear();
        //        Console.WriteLine("             MAIN MENU             ");
        //        Console.WriteLine("--------------------------------------");
        //        Console.WriteLine("|    [1.]  Show All Users          | ");
        //        Console.WriteLine("|    [2.]  Create Account            | ");
        //        Console.WriteLine("|    [3.]  Logout                    | ");
        //        Console.WriteLine("|    [4.]  Exit application          | ");
        //        Console.WriteLine("--------------------------------------");


        //        try
        //        {
        //            int choice = int.Parse(Console.ReadLine());

        //            switch (choice)
        //            {
        //                case 1:
        //                    CurrentUser.ShowAllUsers(Users, CurrentUser);
        //                    break;

        //                case 2:
        //                    // Sending list of Users and CurrentUser and if Admin is true
        //                    User.CreateUser(Users, CurrentUser, true);
        //                    break;

        //                case 3:
        //                    Login logout = new Login();
        //                    logout.UserLogin(Users);
        //                    break;


        //                case 4:
        //                    Environment.Exit(0);
        //                    break;

        //                default:
        //                    Environment.Exit(0);
        //                    break;
        //            }
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Invalid Input!");
        //            Console.ReadLine();
        //        }
        //    } while (true);
        //}






    }



}




