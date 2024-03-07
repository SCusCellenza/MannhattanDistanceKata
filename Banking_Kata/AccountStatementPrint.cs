namespace Banking_Kata
{
    //Class passed internal to avoid other dev to create a non static method
    internal static class AccountStatementPrint
    {

        public static string PrintStatement(List<string> statementList)
        {
            string printedStatement = "Date Amount Balance\n";
            foreach (string statement in statementList)
            {
                printedStatement += statement + "\n";
            }

            return printedStatement;
        }
    }
}