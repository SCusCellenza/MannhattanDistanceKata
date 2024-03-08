namespace Banking_Kata
{
    //Class passed internal to avoid other dev to create a non static method
    internal static class AccountStatementPrint
    {

        public static string PrintStatement(List<BankingTransactionDTO> transactiontList)
        {
            string printedStatement = "Date Amount Balance\n";
            foreach (BankingTransactionDTO transaction in transactiontList)
            {
                printedStatement += $"{transaction.date.ToString("d")} {(transaction.amount >= 0 ? "+" : "")}{transaction.amount} {transaction.balance}\n";
            }
            return printedStatement;
        }
    }
}