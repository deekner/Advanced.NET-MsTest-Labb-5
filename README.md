# Team.Mango.Bank-Application
README for Mango_Bank. 

The Mango_Bank is a group project in school, at Campus Varberg, by four students taking the class SystemDevelopment. The program is coded in C# using .NET 3.1. It is a program meant to function like an internet banking. 

The program is built up of classes: Program.cs, Bankstart, Menu, Login, AdminMenu, User, Bankaccount, Transfer, Transactions, CurrencyRates and InterestRate. 

In Program.cs is where the program starts, with the method Runbank(). 

Runbank is created in BankStart. Here is also where our users and their accounts are created. Each users accounts adds to a List, and later all users are added to another List, so we use List in a List to store our values. The method UserLogin() invokes here.  

LogIn keeps the function for logging in, and if the user is administrator, the AdminMenu() is invoked. If it’s a regular user, the MenuOptions() runs. 

In AdminMenu we have the function for the menu for administrator. The menu consists of following choices:   

1. Show all users – invokes the method ShowAllUsers() which is kept in the class User. 

2. Create account – invokes CreateUser() which is also kept in User. 

3. Logout – invoking UserLogin(), kept in LogIn. 

4. Exit application.  

In Menu, here is where you find the method MenuOptions(), for users.  

1. Accounts – invokes ShowAccountInfo() kept in Bankaccount. 

2. Transfer – invokes TransferMenu() from the class Transfer.  

3. Open new bankaccount – invoking OpenBankAccount() from Bankaccount. 

4. Logout – using UserLogin() in LogIn. 

5. Exit application. 

In User we create the users variables and uses constructors to keep them safe. Here you also find the methods ShowAllUsers(), which loops through the List of users to print out each users name, ShowAccountInfo(), which prints out current users info and sends it to Bankaccount, and CreateUser(), which allows the admin to create a new user and adds it to the List. 

In BankAccount we have the method ShowAccounts(), that with the info sent from ShowAccountInfo() and a loop going through the accounts prints out users info and balance of the accounts. OpenBankAccount() lets the user choose to either open a checkingaccount with OpenCheckingAccount() or a savingaccount using OpenSavingAccount(). 

In Transfer we have a menu to let the user choose to do an internal transfer between their own accounts, or to transfer money to an other users account. Depending on their choice, either invokes InternalTransfer() or UsertoUserTransfer(), both kept in Transfer. 

Transactions, for now, only contains variables for being able to see historic transactions that have taken place, a log of transactions. A feature for the future. 

CurrencyRates keeps the variables for the currency, and the method for updating the currency, UpdateCurrencyRate(). This uses the random method to create a new value of currency. 

InterestRate keeps the variable for the interest rate and the method, IntRateMultiply(), which uses  a random method to calculate a new interest rate. 

 

Collaborateurs of this project are Tim Nilsson @BKKinvader, Dennis Ekner @Deekner, Anton Johansson @Rival7008 and Elin Linderholm @elli82
