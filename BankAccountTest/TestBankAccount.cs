using UnitTesting;

namespace BankAccountTest
{
    public class TestBankAccount
    {

        [Fact]
        public void MakeDeposit_ShouldIncreaseBalance()
        {
            // Arrange
            BankAccount account = new BankAccount(
                "123456", "John Doe", 2000
                );

            float depositAmount = 500;

            float expectedBalance = 2500;

            // Act 
            account.MakeDeposit(depositAmount);

            // Assert
            Assert.Equal( expectedBalance, account.Balance );
        }

    }
}
