namespace Banking_Kata
{
    public class BankingTransactionDTO
    {
        public DateTime date;
        public int amount;
        public int balance;

        public BankingTransactionDTO(DateTime date, int amount, int balance)
        {
            this.date = date;
            this.amount = amount;
            this.balance = balance;
        }
    }
}