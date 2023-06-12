using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Transactions;

namespace Team.Mango.Bank_Application
{
    public class User
    {   // User Constructs
        // We need to make bankaccount in a list
        private string _UserName;
        private string _Password;
        private string _FirstName;
        private string _LastName;
        private string _PhoneNum;
        private List<BankAccount> _BankAccountList;


        // True or false if Admin
        private bool _AdminCheck;

       // Admin is always set to false because only admin have true
        public User(string username, string password, string firstname,string lastname, string phonenum, List<BankAccount> BankAccountList = null, bool AdminCheck = false)
        {
            
            this._UserName = username;
            this._Password = password;
            this._FirstName = firstname;
            this._LastName = lastname;
            this._PhoneNum = phonenum;
            this._BankAccountList = BankAccountList;
            this._AdminCheck = AdminCheck;



        }

        // Return
        public string Username
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string Firstname
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string Lastname
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public  string PhoneNum
        {
            get { return _PhoneNum; }
            set { _PhoneNum = value; }
        }

        public List<BankAccount> BankAccountList
        {
            get { return _BankAccountList; }
            set { _BankAccountList = value; }
        }

        public bool AdminCheck
        {
            get { return _AdminCheck; }
            set { _AdminCheck = value; }
        }

       
        public void ShowAllUsers(List<User> Users, User CurrentUser, CurrencyRates CurrRate)
        {
            Console.Clear();
            int Count = 1;
            foreach(var item in Users)
            {
                Console.WriteLine("User {0}: {1}", Count, item.Username);
                Count++;
            }
            Console.ReadKey();
            AdminMenu SendBack = new AdminMenu();
            SendBack.adminMenu(Users, CurrentUser, CurrRate);
        }

        public void ShowAccountInfo(User CurrentUser)
        {
            Console.Clear();
            Console.WriteLine("Username: {0}", CurrentUser.Username);
            Console.WriteLine("Full Name: {0} {1}", CurrentUser.Firstname, CurrentUser.Lastname);
            Console.WriteLine("Phone number: {0}", CurrentUser.PhoneNum);
            Console.WriteLine();

            // Send Current user to BankAccount class  to see all CurrentUsers banksavings
            BankAccount.ShowAccounts(CurrentUser);
            Console.ReadKey();
            
        }


        //ADMIN CreateUser method
        public static List<User> CreateUser(List<User> Users, User CurrentUser, bool admincheck)
        {
            Console.Clear();
            if (admincheck == true)
            {
                bool existUser = false;
                string username = null;
                string userInput = null;
                // run onetime and if User exist existUser will stay true and the loop begins
                do
                {
                    //Checking if userInput string existing or colide with an existing User using Exists
                    Console.WriteLine("Create new User");
                    Console.WriteLine("Enter Username:");
                    userInput = Console.ReadLine();

                    // Exists: Determines whether the List<T> contains elements that match the conditions defined by the specified predicate.
                    // Contains: Determines whether an element is in the List<T>.
                    existUser = Users.Exists(ex => ex.Username == userInput);



                    if (existUser == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Username already exists, please choose another one.");
                        
                    }
                    else
                    {
                        username = userInput;
                    }
                } while (existUser == true);


                Console.WriteLine("Please choose a password");
                string password = Console.ReadLine();
                Console.Write("First name: ");
                string firstName = Console.ReadLine().ToLower();
                Console.Write("Last name: ");
                string lastName = Console.ReadLine().ToLower();
                Console.Write("Phone number: ");
                string phoneNum = Console.ReadLine();

                //Set new User and set bankaccount in user
                bool notAdmin = false;
                List<BankAccount> newBankAcc = new List<BankAccount>();
                //List<PrivateAccount> newPrivateAccount = new List<PrivateAccount>();
                BankAccount newAcc = new BankAccount("Private Account", 0, "SEK");
                User newUser = new User(username, password, firstName, lastName, phoneNum, newBankAcc, notAdmin);
                newUser.BankAccountList.Add(newAcc);
                Users.Add(newUser);

                Console.WriteLine("Successfully created a new user named {0}",newUser.Username);
                



            }


            return Users;
        }




    }
    




    
}
