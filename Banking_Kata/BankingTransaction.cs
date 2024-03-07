namespace Banking_Kata
{
    public class BankingTransaction
    {
        public DateTime date;
        public int amount;
        public int balance;

        public BankingTransaction(DateTime date, int amount, int balance)
        {
            this.date = date;
            this.amount = amount;
            this.balance = balance;
        }
    }
}