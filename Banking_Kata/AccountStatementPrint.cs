namespace Banking_Kata
{
    //Class passed internal to avoid other dev to create a non static method
    internal static class AccountStatementPrint
    {

        public static string PrintStatement(List<BankingTransaction> statementList)
        {
            string printedStatement = "Date Amount Balance\n";
            foreach (BankingTransaction statement in statementList)
            {
                printedStatement += statement + "\n";
            }

            return printedStatement;
        }
    }
}