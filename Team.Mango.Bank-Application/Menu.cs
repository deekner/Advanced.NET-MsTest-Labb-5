using System;
using System.Collections.Generic;
using System.Text;

namespace Team.Mango.Bank_Application
{
    public class Menu 
    {
        
        public static void MenuOptions(List<User> Users, User CurrentUser, CurrencyRates CurrRate)
        {
            do
            {
                Console.Clear();
                string Mmenu = "             MAIN MENU             ";
                string Mlines = "--------------------------------------";
                string Maccounts = "    [1.]  Accounts                   ";
                string Mtransfer = "    [2.]  Transfer                   ";
                string Mopenaccount = "    [3.]  Open New Bank Account      ";
                string Mlogout = "    [4.]  Logout                     ";
                string Mexit = "    [5.]  Exit application           ";

                Console.SetCursorPosition((Console.WindowWidth - Mmenu.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mmenu);
                Console.SetCursorPosition((Console.WindowWidth - Mlines.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mlines);
                Console.SetCursorPosition((Console.WindowWidth - Maccounts.Length) / 2, Console.CursorTop);
                Console.WriteLine(Maccounts);
                Console.SetCursorPosition((Console.WindowWidth - Mtransfer.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mtransfer);
                Console.SetCursorPosition((Console.WindowWidth - Mopenaccount.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mopenaccount);
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
                            CurrentUser.ShowAccountInfo(CurrentUser);
                            break;

                        case 2:
                            Transfer transfer = new Transfer();
                            transfer.transferMenu(CurrentUser.BankAccountList, CurrentUser, Users, CurrRate);
                            break;

                        case 3:
                            BankAccount.OpenBankAccount(Users, CurrentUser, CurrRate);
                            break;

                        case 4:
                            Login logout = new Login();
                            logout.UserLogin(Users, CurrRate);
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

        
    
      
