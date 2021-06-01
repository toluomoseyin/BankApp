using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models1;
namespace BankApplication1.Data
{
    public class TransactionFileRepository:ITransactionFileRepository
    {


        // This method writes to the file with a comma
        public void WriteToTransactionFile(Transaction newAccount)
        {
            string FilePath = @"C:\Users\hp\Desktop\Week-5 Task\BankApplication.Data\DataBaseFiles\Transactions.txt";
            string data = newAccount.TypeOfTransaction + "," + newAccount.TypeOfAccount + "," + newAccount.Amount + "," + newAccount.DateOfTransaction + "," + newAccount.Note + "," + newAccount.Id + "," + newAccount.AccountNumber + "," + newAccount.AcctBalance;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(FilePath, true))
            {
                file.WriteLine(data);
            }
        }
    }
}
