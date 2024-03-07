



namespace Banking_Kata
{
    internal class Account
    {
        public int amount;
        private List<String> _statement;

        public Account()
        {
            _statement = new List<String> {"Date Amount Balance"};
        }

        public void deposit(int depositAmount)
        {
            amount += depositAmount;
            _statement.Add($"{DateTime.Today.ToString("d")} +{depositAmount} {amount}");
        }

        public void withdraw(int withdramAmount)
        {
            amount -= withdramAmount;
            _statement.Add($"{DateTime.Today.ToString("d")} -{withdramAmount} {amount}");
        }

        public String printStatement()
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