using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    public class AdminMenu
    {
        //ADMIN Menu
        public void adminMenu(List<User> Users, User CurrentUser, CurrencyRates CurrRate)
        {
            do
            {
                //Console.Clear();
                //Console.WriteLine("             MAIN MENU             ");
                //Console.WriteLine("--------------------------------------");
                //Console.WriteLine("|    [1.]  Show All Users            | ");
                //Console.WriteLine("|    [2.]  Create Account            | ");
                //Console.WriteLine("|    [3.]  Update Current Rate:{0} | ", Math.Round(CurrRate._currencyRate, 2));
                //Console.WriteLine("|    [4.]  Logout                    | ");
                //Console.WriteLine("|    [5.]  Exit application          | ");
                //Console.WriteLine("--------------------------------------");

                Console.Clear();
                string Mmenu = "             MAIN MENU             ";
                string Mlines = "--------------------------------------";
                string Maccounts = "    [1.]  Show All Users             ";
                string CreateA = "    [2.]  Create Account             ";
                string UpdateCurr = " [3.]  Update Current Rate:    ";
                string Mlogout = "    [4.]  Logout                     ";
                string Mexit = "    [5.]  Exit application           ";

                Console.SetCursorPosition((Console.WindowWidth - Mmenu.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mmenu);
                Console.SetCursorPosition((Console.WindowWidth - Mlines.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mlines);
                Console.SetCursorPosition((Console.WindowWidth - Maccounts.Length) / 2, Console.CursorTop);
                Console.WriteLine(Maccounts);
                Console.SetCursorPosition((Console.WindowWidth - CreateA.Length) / 2, Console.CursorTop);
                Console.WriteLine(CreateA);
                Console.SetCursorPosition((Console.WindowWidth - UpdateCurr.Length) / 2, Console.CursorTop);
                Console.WriteLine(UpdateCurr + Math.Round(CurrRate._currencyRate, 2));
                Console.SetCursorPosition((Console.WindowWidth - Mlogout.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mlogout);
                Console.SetCursorPosition((Console.WindowWidth - Mexit.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mexit);
                Console.SetCursorPosition((Console.WindowWidth - Mlines.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mlines);



                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            CurrentUser.ShowAllUsers(Users, CurrentUser, CurrRate);
                            break;

                        case 2:
                            // Sending list of Users and CurrentUser and if Admin is true
                            User.CreateUser(Users, CurrentUser, true);
                            break;

                        case 3:
                            CurrencyRates.UpdateCurrentcyRate(CurrRate);
                            break;

                        case 4:
                            Login logout = new Login();
                            logout.UserLogin(Users, CurrRate);
                            break;



                        case 5:
                            Environment.Exit(0);
                            break;

                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input!");
                    Console.ReadLine();
                }
            } while (true);
        }


    }
}
