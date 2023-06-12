using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Team.Mango.Bank_Application;
using static Team.Mango.Bank_Application.Mock;

namespace Labb5_Test
{
    [TestClass]
    public class LoginTests
    {

        [TestMethod]
        public void UserLogin_WithMatchingUsernameAndPassword_ShouldGrantAccess()
        {
            //Arrange
            var mock = new Mock();
            var users = new List<User>();
            List<BankAccount> AM = new List<BankAccount>();

            BankAccount AdminBAccount = new BankAccount("No money", 0000, "SEK");
            User Admin = new User("admin", "admin", "Tony", "Stark", "2129704133", AM, true);

            Admin.BankAccountList.Add(AdminBAccount);
            users.Add(Admin);


            //Act
            mock.UserLogin(users, "admin", "admin"); //Checks correct user credentials!


            //Assert
            Assert.IsTrue(mock.LoginGranted);

        }

















        //[TestMethod]
        //public void LogIn_ShouldGrantLogin()
        //{
        //    ///AAA
        //    ///

        //    // Arrange
        //    List<User> Users = new List<User>();

        //    List<CurrencyRates> Rates = new List<CurrencyRates>();
        //    CurrencyRates USDRates = new CurrencyRates("USD", 10.33);
        //    CurrencyRates SEKRates = new CurrencyRates("SEK", 0);
        //    Rates.Add(USDRates);
        //    Rates.Add(SEKRates);

        //    List<BankAccount> AM = new List<BankAccount>();
        //    BankAccount AdminBAccount = new BankAccount("No money", 0000, "SEK");

        //    User Admin = new User("admin", "admin", "Tony", "Stark", "2129704133", AM, true);
        //    Admin.BankAccountList.Add(AdminBAccount);
        //    Users.Add(Admin);


        //    // Act
        //    Mock mock = new Mock();
        //    mock.UserLogin(Users, SEKRates);


        //    // Assert
        //    Assert.IsTrue(mock.LoginGranted);
        //}
    }
}