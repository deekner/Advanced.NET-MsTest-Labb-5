using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Mango.Bank_Application;

namespace Labb5_Test
{
    [TestClass]

    public class TransactionsTest
    {
        [TestMethod]
        public void internalTransfer_ShouldNotBeAbleToTransferMoreThanAccountBalance()
        {
            ///AAA
            ///

            //Arrange
            List<User> users = new List<User>();
            var DA3 = new List<BankAccount>();
            BankAccount DAccount1 = new BankAccount("Daily account", 10000, "SEK");
            BankAccount DAccount2 = new BankAccount("Savings account", 200, "SEK");
            User TestUser1 = new User("Dennis", "3333", "Dennis", "Ekner", "070427245", DA3, false);
            TestUser1.BankAccountList.Add(DAccount1);
            TestUser1.BankAccountList.Add(DAccount2);
            users.Add(TestUser1);
            DA3.Add(DAccount1);
            DA3.Add(DAccount2);

            int accountFrom = TestUser1.BankAccountList.IndexOf(DAccount1); // Get the index of DAccount1
            int accountTo = TestUser1.BankAccountList.IndexOf(DAccount2); // Get the index of DAccount2
            double transferAmount = 10000;

            //Act
            Mock mock = new Mock();
            // Attempt to transfer more than the balance of DAccount1
            mock.internalTransfer(DA3, TestUser1, accountFrom, accountTo, transferAmount);


            // Assert that the transfer amount has been added to DAccount2
            Assert.AreEqual(200 + transferAmount, DAccount2.Balance);

        }
    }
}
