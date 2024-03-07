
namespace Banking_Kata
{
    internal class Account : AccountStatementPrint
    {
        public int amount { get; private set; }
        public List<String> statement { get; private set; }

        public Account()
        {
            statement = new List<String> {"Date Amount Balance"};
        }

        public void Deposit(int depositAmount)
        {
            amount += depositAmount;
            statement.Add($"{DateTime.Today.ToString("d")} +{depositAmount} {amount}");
        }

        public void Withdraw(int withdrawAmount)
        {
            amount -= withdrawAmount;
            statement.Add($"{DateTime.Today.ToString("d")} -{withdrawAmount} {amount}");
        }
    }
}