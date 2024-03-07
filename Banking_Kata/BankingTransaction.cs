namespace Banking_Kata
{
    public class BankingTransaction
    {
        public DateTime date;
        public int depositAmount;
        public int balance;

        public BankingTransaction(DateTime date, int depositAmount, int balance)
        {
            this.date = date;
            this.depositAmount = depositAmount;
            this.balance = balance;
        }
    }
}