using System;
using System.Collections.Generic;
using System.Threading;

namespace Team.Mango.Bank_Application
{
    public class Transfer
    {
        public int accFrom = 0;
        public int accTo = 0;
        public double transferAmmount = 0;
        // Who to transfer to
        public string transferTo = "";



        // In transfer
        public void transferMenu(List<BankAccount> CurrentUserAccounts, User CurrentUser, List<User> Users, CurrencyRates CurrRate)
        {
            bool Tmenu = true;

            do
            {
                //Console.Clear();
                //Console.WriteLine("             TRANSFER MENU             ");
                //Console.WriteLine("--------------------------------------");
                //Console.WriteLine("|    [1.]  Internal Transfers        | ");
                //Console.WriteLine("|    [2.]  Transfer to other user    | ");
                //Console.WriteLine("|    [3.]  Go back                   | ");
                //Console.WriteLine("--------------------------------------");



                Console.Clear();
                string Mmenu = "             TRANSFER MENU             ";
                string Mlines = "--------------------------------------";
                string MInTransfer = "|    [1.]  Internal Transfers        | ";
                string Mtransferto = "|    [2.]  Transfer to other user    | ";
                string MGoback = "|    [3.]  Go back                   | ";
                

                Console.SetCursorPosition((Console.WindowWidth - Mmenu.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mmenu);
                Console.SetCursorPosition((Console.WindowWidth - Mlines.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mlines);
                Console.SetCursorPosition((Console.WindowWidth - MInTransfer.Length) / 2, Console.CursorTop);
                Console.WriteLine(MInTransfer);
              
                Console.SetCursorPosition((Console.WindowWidth - Mtransferto.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mtransferto);
                Console.SetCursorPosition((Console.WindowWidth - MGoback.Length) / 2, Console.CursorTop);
                Console.WriteLine(MGoback);
                Console.SetCursorPosition((Console.WindowWidth - Mlines.Length) / 2, Console.CursorTop);
                Console.WriteLine(Mlines);
                

                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            internalTransfer(CurrentUserAccounts, CurrentUser, CurrRate);
                            break;

                        case 2:
                            UserToUserTransfer(CurrentUserAccounts, CurrentUser, Users, CurrRate);
                            break;

                        case 3:
                            Tmenu = false;
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


            } while (Tmenu);


        }
        public void internalTransfer(List<BankAccount> CurrentUserAccounts, User CurrentUser, CurrencyRates CurrRate)
        {
            //iTloop = "internal transfer loop"
            bool iTloop1 = true;
            bool iTloop2 = true;

            int maxAccNum = CurrentUserAccounts.Count;

            while (iTloop1)
            {
                // Account From
                Console.Clear();
                Console.WriteLine("Select the account that you want to transfer from.");
                int AccNum = 1;
                foreach (BankAccount item in CurrentUser.BankAccountList)
                {
                    Console.WriteLine(AccNum + $": Account name: {item.AccountName} Balance: {item.Balance} {item.CurrencyType}");
                    AccNum++;
                }


                // Choose account that you want to transferform
                accFrom = int.Parse(Console.ReadLine());
                if (accFrom <= maxAccNum && accFrom > 0)
                {
                    iTloop1 = false;
                }
                else
                {
                    Console.WriteLine("Please select an existing account \nPress enter to continue.");
                    Console.ReadKey();
                }


            }

            //Account To
            while (iTloop2)
            {
                Console.Clear();
                Console.WriteLine("Select the account that you want to tranfer to.");
                int AccNum = 1;
                foreach (BankAccount item in CurrentUser.BankAccountList)
                {
                    Console.WriteLine(AccNum + $": Account name: {item.AccountName} Balance: {item.Balance} {item.CurrencyType}");
                    AccNum++;
                }

                try
                {
                    accTo = int.Parse(Console.ReadLine());
                    if (accTo <= maxAccNum && accTo != accFrom && accTo > 0)
                    {
                        iTloop2 = false;

                    }

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Please select an existing account");
                }



                //Selecting ammount

                Console.Clear();
                Console.WriteLine("Select the ammount.");
                try
                {
                    transferAmmount = double.Parse(Console.ReadLine());
                    if (transferAmmount > 0 && transferAmmount <= CurrentUserAccounts[accFrom].Balance)
                    {
                        iTloop2 = false;
                    }
                    else
                    {
                        Console.WriteLine("You can not transfer less then 0 \nPress enter to try again");
                        Console.ReadKey();
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Just numbers !!!!!");
                }

            }

            // Transfering process
            // Minus 1 is because account start from 0 
            accFrom = accFrom - 1;
            accTo = accTo - 1;
            bool TSuccess = false;
            //CurrentUserAccounts[] is a way to access index of CurrentUsers Bankaccount 

            if (CurrentUserAccounts[accFrom].CurrencyType == "USD" && CurrentUserAccounts[accFrom].Balance >= transferAmmount && CurrentUserAccounts[accTo].CurrencyType == "SEK")
            {
                Console.WriteLine("USD rate is {0} ", Math.Round(CurrRate._currencyRate, 2));
                CurrentUserAccounts[accFrom].Balance -= transferAmmount;
                CurrentUserAccounts[accTo].Balance += transferAmmount * CurrRate._currencyRate;
                Console.WriteLine("You have transfered {0} {1} from account {2} to accout {3}", transferAmmount, CurrentUserAccounts[accFrom].CurrencyType, accFrom + 1, accTo + 1);
                Console.WriteLine(" {0} {1} => {2} {3} ", transferAmmount, CurrentUserAccounts[accFrom].CurrencyType, transferAmmount * CurrRate._currencyRate, CurrentUserAccounts[accTo].CurrencyType);
                Console.ReadKey();
                TSuccess = true;
            }
            if (CurrentUserAccounts[accFrom].CurrencyType == "SEK" && CurrentUserAccounts[accFrom].Balance >= transferAmmount && CurrentUserAccounts[accTo].CurrencyType == "USD")
            {
                Console.WriteLine("USD rate is {0}", Math.Round(CurrRate._currencyRate, 2));
                CurrentUserAccounts[accFrom].Balance -= transferAmmount;
                CurrentUserAccounts[accTo].Balance += transferAmmount / CurrRate._currencyRate;
                Console.WriteLine("You have transfered {0} {1} from account {2} to accout {3}", transferAmmount, CurrentUserAccounts[accFrom].CurrencyType, accFrom + 1, accTo + 1);
                Console.WriteLine(" {0} {1} => {2} {3} ", transferAmmount, CurrentUserAccounts[accFrom].CurrencyType, transferAmmount / CurrRate._currencyRate, CurrentUserAccounts[accTo].CurrencyType);
                Console.ReadKey();
                TSuccess = true;
            }

            if (CurrentUserAccounts[accFrom].CurrencyType == "SEK" && CurrentUserAccounts[accTo].CurrencyType == "SEK" && CurrentUserAccounts[accFrom].Balance >= transferAmmount)
            {
                CurrentUserAccounts[accFrom].Balance -= transferAmmount;
                CurrentUserAccounts[accTo].Balance += transferAmmount;
                TSuccess = true;

            }


            if (TSuccess == true)
            {
                Console.Clear();
                Console.WriteLine("Account number {0} balance is now {1} {2}\nAccount number {3} balance is now {4} {5}", accFrom + 1, CurrentUserAccounts[accFrom].Balance, CurrentUserAccounts[accFrom].CurrencyType, accTo + 1, CurrentUserAccounts[accTo].Balance, CurrentUserAccounts[accTo].CurrencyType);
                Console.ReadKey();

            }
        }

        public void UserToUserTransfer(List<BankAccount> CurrentUserAccounts, User CurrentUser, List<User> Users, CurrencyRates CurrRate)
        {
            Console.Clear();
            // Maximum account that the user owns
            int maxAccNum = CurrentUserAccounts.Count;
            // Account start with num else it will start at 0
            int AccNum = 1;


            bool Tloop1 = true;
            bool Tloop2 = true;
            bool Tloop3 = true;


            //Tloop 1
            // select from which account
            while (Tloop1)
            {
                Console.WriteLine("Select the account that you want to transfer from.");
                foreach (BankAccount item in CurrentUser.BankAccountList)
                {
                    Console.WriteLine(AccNum + $": Account name: {item.AccountName} Balance: {item.Balance} {item.CurrencyType}");
                    AccNum++;
                }

                try
                {
                    // Choose account that you want to transferform
                    accFrom = int.Parse(Console.ReadLine());
                    accFrom = accFrom - 1;
                    if (accFrom <= maxAccNum && accFrom >= 0)
                    {
                        Tloop1 = false;
                    }
                    else
                    {
                        Console.WriteLine("Please select an existing account \nPress enter to continue.");
                        Console.ReadKey();
                    }

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Please select existing account");
                }
            }

            //Tloop 2
            // Typing\Search user to transfer to by string
            while (Tloop2)
            {
                Console.Clear();
                Console.WriteLine("Write the username of the user you want to transfer to");

                try
                {
                    // Make user search for User by text
                    transferTo = Console.ReadLine();
                    User transferToUser = Users.Find(F => F.Username == transferTo);

                    if (transferTo == transferToUser.Username)
                    {
                        //Close loop if successfully found username 
                        Console.WriteLine("{0} is found", transferTo);
                        Console.ReadKey();
                        Tloop2 = false;

                    }
                    else if (transferTo != transferToUser.Username)
                    {
                        Console.WriteLine("User not found");
                        Tloop2 = true;
                    }



                }
                catch (Exception)
                {
                    Console.WriteLine("User not found");
                }


            }
            //Tloop3 Select ammount
            while (Tloop3)
            {
                Console.Clear();
                Console.WriteLine("Select the ammount that you want to transfer");
                try
                {
                    transferAmmount = double.Parse(Console.ReadLine());
                    if (transferAmmount > 0)
                    {

                        Tloop3 = false;
                    }
                    else
                    {
                        Console.WriteLine("You can not transfer less then 0 \nPress enter to try again");
                        Console.ReadKey();
                    }

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Input only numbers");
                    Console.WriteLine("Press any key to try again");
                    Console.ReadLine();
                }

            }

            Console.Clear();


            bool success = true;
            User transferToUser1 = Users.Find(f => f.Username == transferTo);
            List<BankAccount> accName = transferToUser1.BankAccountList.FindAll(BA => BA.Balance >= 0);
            BankAccount name = accName.Find(BA => BA.Balance > 0);

            while (success)
            {


                if (CurrentUserAccounts[accFrom].CurrencyType == "USD" && CurrentUserAccounts[accFrom].Balance >= transferAmmount && CurrentUserAccounts[accTo].CurrencyType == "SEK")
                {
                    Console.WriteLine("USD rate is {0} ", Math.Round(CurrRate._currencyRate, 2));
                    CurrentUserAccounts[accFrom].Balance -= transferAmmount;
                    accName[0].Balance += transferAmmount * CurrRate._currencyRate;
                    Console.WriteLine("You have transfered {0} {1} from account {2} to {3}", transferAmmount, CurrentUserAccounts[accFrom].CurrencyType, accFrom + 1, transferTo);
                    Console.WriteLine(" {0} {1} => {2} {3} ", transferAmmount, CurrentUserAccounts[accFrom].CurrencyType, transferAmmount * CurrRate._currencyRate, accName[0].CurrencyType);
                    success = false;


                }
                else
                {
                    //CurrentUsers account
                    CurrentUserAccounts[accFrom].Balance -= transferAmmount;
                    Console.WriteLine("Please wait 10 seconds");
                    Thread.Sleep(10000);
                    //User to transfer to acocunt
                    accName[0].Balance += transferAmmount;
                    Console.WriteLine("You have transfered {0} {1} from account name: {2} to {3}", transferAmmount, CurrentUserAccounts[accFrom].CurrencyType, CurrentUserAccounts[accFrom].AccountName, transferTo);

                    success = false;
                }
            }
            if (success == false)
            {
                // Transfer success

                Console.WriteLine("Press enter to go back");
                Console.ReadKey();
            }

        }

    }
}
