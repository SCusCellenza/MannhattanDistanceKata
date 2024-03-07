



namespace Banking_Kata
{
    internal class Account
    {
        public int amount;
        public List<String> statement;

        public Account()
        {
            statement = new List<String> {"Date Amount Balance"};
        }

        public void deposit(int depositAmount)
        {
            amount += depositAmount;
            statement.Add($"{ DateTime.Today} +{depositAmount} {amount}");
        }

        public void withdraw(int withdramAmount)
        {
            amount -= withdramAmount;
            statement.Add($"{DateTime.Today} -{withdramAmount} {amount}");
        }

        public String printStatement()
        {
            String printedStatement = "";
            foreach (String statement in statement)
            {
                printedStatement += statement + "\n";
            }

            return printedStatement;
        }
    }
}