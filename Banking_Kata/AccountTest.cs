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
            account.Deposit(500);

            //Assert
            Assert.Equal(500, account.balance);
        }

        [Fact]
        public void WhenAWithdrawIsDone_BankAccountDecreasesByThisAmount()
        {
            //Arrange 
            Account account = new Account();

            //Act
            account.Withdraw(500);

            //Assert
            Assert.Equal(-500, account.balance);
        }

        [Fact]
        public void WhenAWithdrawAfterDepositIsDone_BankAccountShouldBeEqualToDepositMinusWithDraw()
        {
            //Arrange 
            Account account = new Account();

            //Act
            account.Deposit(500);
            account.Withdraw(500);

            //Assert
            Assert.Equal(0, account.balance);
        }
    }
}