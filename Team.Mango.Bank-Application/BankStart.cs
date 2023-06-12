using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Team.Mango.Bank_Application
{
    public class BankStart
    {       // In here we will start the bankprogram
        public void RunBank()
        {
            welcome();
            //Making a list of Users from User
            List<User> Users = new List<User>();


            //Create currency
            List<CurrencyRates> Rates = new List<CurrencyRates>();
            CurrencyRates USDRates = new CurrencyRates("USD", 10.33);
            CurrencyRates SEKRates = new CurrencyRates("SEK", 0);
            Rates.Add(USDRates);
            Rates.Add(SEKRates);




            //Create Admin
            List<BankAccount> AM = new List<BankAccount>();
            BankAccount AdminBAccount = new BankAccount("No money", 0000, "SEK");
            User Admin = new User("admin", "admin", "Tony", "Stark", "2129704133", AM, true);     
            Admin.BankAccountList.Add(AdminBAccount);
            Users.Add(Admin);



            //User 1
            //Making a list of Tim Bankaccount "BA1"
            List<BankAccount> TA1 = new List<BankAccount>();
            //Create default bankaccount
            BankAccount TAccount1 = new BankAccount("Private account", 25000, "SEK");
            BankAccount TAccount2 = new BankAccount("Private account", 500, "USD");
            BankAccount TAccount3 = new BankAccount("Private account", 4989056456897,"SEK");


            //Create User
            User User1 = new User("Tim", "1111", "Tim", "Nilsson", "0709496224", TA1, false);

            //Add BAccount1 to BankAccountList
            User1.BankAccountList.Add(TAccount1);
            User1.BankAccountList.Add(TAccount2);
            User1.BankAccountList.Add(TAccount3);
            //Add User1 to Users List
            Users.Add(User1);



            //User 2
            List<BankAccount> EA2 = new List<BankAccount>();
            BankAccount EAccount1= new BankAccount("Private account", 2000, "SEK");
            BankAccount EAccount2 = new BankAccount("Private account", 2500, "USD");
            BankAccount EAccount3 = new BankAccount("Private account", 497, "SEK");
            User User2= new User("Elin", "2222", "Elin", "Linderholm", "0708687334", EA2, false);
            User2.BankAccountList.Add(EAccount1);
            User2.BankAccountList.Add(EAccount2);
            User2.BankAccountList.Add(EAccount3);
            Users.Add(User2);


            //User 3
            List<BankAccount> DA3 = new List<BankAccount>();
            BankAccount DAccount1 = new BankAccount("Private account", 200, "USD");
            BankAccount DAccount2 = new BankAccount("Private account", 20230000, "SEK");
            User User3 = new User("Dennis", "3333", "Dennis", "Ekner", "070427245", DA3, false);
            User3.BankAccountList.Add(DAccount1);
            User3.BankAccountList.Add(DAccount2);
            Users.Add(User3);



            //User 4
            List<BankAccount> AA4 = new List<BankAccount>();
            BankAccount AAccount1 = new BankAccount("Private account", 250, "USD");
            BankAccount AAccount2 = new BankAccount("Private account", 2600, "SEK");
            User User4 = new User("Anton", "4444", "Anton", "Johansson", "0708687334", AA4, false);
            User4.BankAccountList.Add(AAccount1);
            User4.BankAccountList.Add(AAccount2);
            Users.Add(User4);


          


            //Create object of Login
            Login login = new Login();
            //Send Users list data to UserLogin() 
            login.UserLogin(Users,USDRates);


            





        }

        public void welcome()
        {

            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < 100; i++)
            {
                Console.CursorVisible = false;
                if (i > 0 && i < 10)
                {

                    string boot0 = "BOOTING:" + i + "%";
                    string load0 = "[■         ]";
                    Console.SetCursorPosition((Console.WindowWidth - boot0.Length) / 2, Console.CursorTop);
                    Console.WriteLine(boot0);
                    Console.SetCursorPosition((Console.WindowWidth - load0.Length) / 2, Console.CursorTop);
                    Console.WriteLine(load0);
                    Thread.Sleep(50);
                    Console.SetCursorPosition(0, 0);
                }
                if (i > 20 && i < 30)
                {

                    string boot20 = "BOOTING:" + i + "%";
                    string load20 = "[■■        ]";
                    Console.SetCursorPosition((Console.WindowWidth - boot20.Length) / 2, Console.CursorTop);
                    Console.WriteLine(boot20);
                    Console.SetCursorPosition((Console.WindowWidth - load20.Length) / 2, Console.CursorTop);
                    Console.WriteLine(load20);
                    Thread.Sleep(60);
                    Console.SetCursorPosition(0, 0);

                }
                if (i > 30 && i < 40)
                {


                    string boot30 = "BOOTING:" + i + "%";
                    string load30 = "[■■■       ]";
                    Console.SetCursorPosition((Console.WindowWidth - boot30.Length) / 2, Console.CursorTop);
                    Console.WriteLine(boot30);
                    Console.SetCursorPosition((Console.WindowWidth - load30.Length) / 2, Console.CursorTop);
                    Console.WriteLine(load30);
                    Thread.Sleep(70);
                    Console.SetCursorPosition(0, 0);


                }
                if (i > 40 && i < 50)
                {


                    string boot40 = "BOOTING:" + i + "%";
                    string load40 = "[■■■■      ]";
                    Console.SetCursorPosition((Console.WindowWidth - boot40.Length) / 2, Console.CursorTop);
                    Console.WriteLine(boot40);
                    Console.SetCursorPosition((Console.WindowWidth - load40.Length) / 2, Console.CursorTop);
                    Console.WriteLine(load40);
                    Thread.Sleep(30);
                    Console.SetCursorPosition(0, 0);
                }
                if (i > 50 && i < 60)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    string boot50 = "BOOTING:" + i + "%";
                    string load50 = "[■■■■■     ]";
                    Console.SetCursorPosition((Console.WindowWidth - boot50.Length) / 2, Console.CursorTop);
                    Console.WriteLine(boot50);
                    Console.SetCursorPosition((Console.WindowWidth - load50.Length) / 2, Console.CursorTop);
                    Console.WriteLine(load50);
                    Thread.Sleep(70);
                    Console.SetCursorPosition(0, 0);



                }
                if (i > 60 && i < 70)
                {


                    string boot60 = "BOOTING:" + i + "%";
                    string load60 = "[■■■■■■    ]";
                    Console.SetCursorPosition((Console.WindowWidth - boot60.Length) / 2, Console.CursorTop);
                    Console.WriteLine(boot60);
                    Console.SetCursorPosition((Console.WindowWidth - load60.Length) / 2, Console.CursorTop);
                    Console.WriteLine(load60);
                    Thread.Sleep(50);
                    Console.SetCursorPosition(0, 0);

                }
                if (i > 70 && i < 80)
                {


                    string boot70 = "BOOTING:" + i + "%";
                    string load70 = "[■■■■■■■   ]";
                    Console.SetCursorPosition((Console.WindowWidth - boot70.Length) / 2, Console.CursorTop);
                    Console.WriteLine(boot70);
                    Console.SetCursorPosition((Console.WindowWidth - load70.Length) / 2, Console.CursorTop);
                    Console.WriteLine(load70);
                    Thread.Sleep(70);
                    Console.SetCursorPosition(0, 0);

                }
                if (i > 80 && i < 90)
                {



                    string boot80 = "BOOTING:" + i + "%";
                    string load80 = "[■■■■■■■■  ]";
                    Console.SetCursorPosition((Console.WindowWidth - boot80.Length) / 2, Console.CursorTop);
                    Console.WriteLine(boot80);
                    Console.SetCursorPosition((Console.WindowWidth - load80.Length) / 2, Console.CursorTop);
                    Console.WriteLine(load80);
                    Thread.Sleep(80);
                    Console.SetCursorPosition(0, 0);

                }
                if (i > 90 && i < 100)
                {


                    string boot90 = "BOOTING:" + i + "%";
                    string load90 = "[■■■■■■■■■ ]";
                    Console.SetCursorPosition((Console.WindowWidth - boot90.Length) / 2, Console.CursorTop);
                    Console.WriteLine(boot90);
                    Console.SetCursorPosition((Console.WindowWidth - load90.Length) / 2, Console.CursorTop);
                    Console.WriteLine(load90);
                    Thread.Sleep(80);
                    Console.SetCursorPosition(0, 0);

                }

            }
            Console.ForegroundColor = ConsoleColor.White;
            string boot100 = "COMPLETE:" + "100" + "%";
            string load100 = "[■■■■■■■■■■]";
            Console.SetCursorPosition((Console.WindowWidth - boot100.Length) / 2, Console.CursorTop);
            Console.WriteLine(boot100);
            Console.SetCursorPosition((Console.WindowWidth - load100.Length) / 2, Console.CursorTop);
            Console.WriteLine(load100);
            Thread.Sleep(1500);
            Console.SetCursorPosition(0, 0);



            static void ConsoleDraw(IEnumerable<string> lines, int x, int y)
            {
                Console.Clear();
                if (x > Console.WindowWidth) return;
                if (y > Console.WindowHeight) return;

                var trimLeft = x < 0 ? -x : 0;
                int index = y;

                x = x < 0 ? 0 : x;
                y = y < 0 ? 0 : y;

                var linesToPrint =
                    from line in lines
                    let currentIndex = index++
                    where currentIndex > 0 && currentIndex < Console.WindowHeight
                    select new
                    {
                        Text = new String(line.Skip(trimLeft).Take(Math.Min(Console.WindowWidth - x, line.Length - trimLeft)).ToArray()),
                        X = x,
                        Y = y++
                    };

                Console.Clear();
                foreach (var line in linesToPrint)
                {
                    Console.SetCursorPosition(line.X, line.Y);
                    Console.Write(line.Text);
                }
            }


            Console.CursorVisible = false;

            var arr = new[]
            {
            @"  ███╗░░░███╗░█████╗░███╗░░██╗░██████╗░░█████╗░",
            @"  ████╗░████║██╔══██╗████╗░██║██╔════╝░██╔══██╗",
            @"  ██╔████╔██║███████║██╔██╗██║██║░░██╗░██║░░██║",
            @"  ██║╚██╔╝██║██╔══██║██║╚████║██║░░╚██╗██║░░██║",
            @"  ██║░╚═╝░██║██║░░██║██║░╚███║╚██████╔╝╚█████╔╝",
            @"  ╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝░╚═════╝░░╚════╝░",
            @"  ██████╗░░█████╗░███╗░░██╗██╗░░██╗  ██╗",
            @"  ██╔══██╗██╔══██╗████╗░██║██║░██╔╝  ██║",
            @"  ██████╦╝███████║██╔██╗██║█████═╝░  ██║",
            @"  ██╔══██╗██╔══██║██║╚████║██╔═██╗░  ╚═╝",
            @"  ██████╦╝██║░░██║██║░╚███║██║░╚██╗  ██╗",
            @"  ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝  ╚═╝",
                };

            var maxLength = arr.Aggregate(0, (max, line) => Math.Max(max, line.Length));
            var x = Console.BufferWidth / 2 - maxLength / 2;
            for (int y = -arr.Length; y < Console.WindowHeight + arr.Length; y++)
            {
                ConsoleDraw(arr, x, y);
                Thread.Sleep(100);
            }



        }
    }
}



