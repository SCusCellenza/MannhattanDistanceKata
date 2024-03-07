namespace Banking_Kata
{
    public class AccountTest
    {
        [Fact]
        public void WhenADepositInMade_BankAccountInceasesByThisAmount()
        {
            //Arrange 
            Account account = new Account();

            //Act
            account.deposit(500);

            //Assert
            Assert.Equal(500, account.amount);
        }

        [Fact]
        public void WhenAWithdrawIsDone_BankAccountDecreasesByThisAmount()
        {
            //Arrange 
            Account account = new Account();

            //Act
            account.withdraw(500);

            //Assert
            Assert.Equal(-500, account.amount);
        }

        [Fact]
        public void WhenAPrintStatementIsAskedAfterTheFirstDeposit_DateAmountAndBalanceArePrinted()
        {
            //Arrange 
            Account account = new Account();
            string expectedOutput = "Date Amount Balance\n" +
                                    $"{DateTime.Today.ToString("d")} +500 500\n";
            //Act
            account.deposit(500);

            //Assert
            Assert.Equal(expectedOutput, account.printStatement());
        }

        [Fact]
        public void WhenAPrintStatementIsAskedAfterADepositAndAWithdraw_DateAmoutAndBalanceArePrinted()
        {
            //Arrange 
            Account account = new Account();
            string expectedOutput = "Date Amount Balance\n" +
                                    $"{DateTime.Today.ToString("d")} +500 500\n" +
                                    $"{DateTime.Today.ToString("d")} -100 400\n";

            //Act
            account.deposit(500);
            account.withdraw(100);

            //Assert
            Assert.Equal(expectedOutput, account.printStatement());
        }
    }
}