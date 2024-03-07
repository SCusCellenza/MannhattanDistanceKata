namespace Banking_Kata
{
    internal class AccountStatementPrint
    {

        public static String PrintStatement(List<String> statementList)
        {
            String printedStatement = "";
            foreach (String statement in statementList)
            {
                printedStatement += statement + "\n";
            }

            return printedStatement;
        }
    }
}