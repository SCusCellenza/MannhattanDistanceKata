namespace Banking_Kata
{
    public class AccountStatementPrintTest
    {

        [Fact]
        public void WhenAPrintStatementIsAskedAfterTheFirstDeposit_DateAmountAndBalanceArePrinted()
        {
            //Arrange 
            Account account = new Account();
            string expectedOutput = "Date Amount Balance\n" +
                                    $"{DateTime.Today.ToString("d")} +500 500\n";
            
            //Act
            account.Deposit(500);

            //Assert
            Assert.Equal(expectedOutput, AccountStatementPrint.PrintStatement(account.statement));
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
            account.Deposit(500);
            account.Withdraw(100);

            //Assert
            Assert.Equal(expectedOutput, AccountStatementPrint.PrintStatement(account.statement));
        }
    }
}