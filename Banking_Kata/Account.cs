
namespace Banking_Kata
{
    internal class Account
    {
        public int amount { get; private set; }
        public List<string> statement { get; private set; }

        public Account()
        {
            statement = new List<string>();
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