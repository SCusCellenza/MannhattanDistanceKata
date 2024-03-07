
namespace Banking_Kata
{
    internal class Account
    {
        public int balance { get; private set; }
        public List<BankingTransaction> statement { get; private set; }

        public Account()
        {
            statement = new List<BankingTransaction>();
        }

        public void Deposit(int depositAmount)
        {
            balance += depositAmount;
            statement.Add(new BankingTransaction(DateTime.Today, +depositAmount, balance));
        }

        public void Withdraw(int withdrawAmount)
        {
            balance -= withdrawAmount;
            statement.Add(new BankingTransaction(DateTime.Today, -withdrawAmount, balance));
        }
    }
}