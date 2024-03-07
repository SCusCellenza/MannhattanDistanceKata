
namespace Banking_Kata
{
    internal class Account
    {
        public int amount { get; private set; }
        private List<String> _statement;

        public Account()
        {
            _statement = new List<String> {"Date Amount Balance"};
        }

        public void Deposit(int depositAmount)
        {
            amount += depositAmount;
            _statement.Add($"{DateTime.Today.ToString("d")} +{depositAmount} {amount}");
        }

        public void Withdraw(int withdrawAmount)
        {
            amount -= withdrawAmount;
            _statement.Add($"{DateTime.Today.ToString("d")} -{withdrawAmount} {amount}");
        }

        public String PrintStatement()
        {
            String printedStatement = "";
            foreach (String statement in _statement)
            {
                printedStatement += statement + "\n";
            }

            return printedStatement;
        }
    }
}