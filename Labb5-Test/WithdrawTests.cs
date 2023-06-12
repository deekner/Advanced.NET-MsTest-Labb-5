using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Mango.Bank_Application;

namespace Labb5_Test
{
    [TestClass]
    public class WithdrawTests
    {
        [TestMethod]
        public void Withdraw_ShouldNotBeableToWithDrawMoreMoneyThanAvailableBalance_ShouldResultNotBeingAbleToWithdrawMoreMoneythanAccountBalance()
        {
            ///AAA
            ///

            //Arrange
            List<User> users = new List<User>();
            var TB = new List<BankAccount>();
            BankAccount TestBankAccount = new BankAccount("Bank account", 2000, "SEK");
            User TestUser = new User("Thomas", "1111", "Thomas", "Andersson", "070496442", TB, false);
            TestUser.BankAccountList.Add(TestBankAccount);
            users.Add(TestUser);
            TB.Add(TestBankAccount);

            double WithdrawAmount = 2000;

            //Act
            Withdraw withdrawClass = new Withdraw();
            withdrawClass.withdraw(TB, TestUser, WithdrawAmount);

            //Assert
            Assert.AreEqual(2000 - WithdrawAmount, TestBankAccount.Balance);
        }
    }
}
