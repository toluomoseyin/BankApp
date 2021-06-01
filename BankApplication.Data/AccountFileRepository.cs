using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models1;

namespace BankApplication1.Data
{
    public class AccountFileRepository:IAccountFileRepository
    {
        public AccountFileRepository()
        {

        }

        // This method writes to the file with a comma
        public void WriteToAccountFile(Account newAccount)
        {
            string FilePath = @"C:\Users\hp\Desktop\Week-5 Task\BankApplication.Data\DataBaseFiles\Accounts.txt";
            string data = newAccount.AccountNumber + "," + newAccount.OwnerId + "," + newAccount.DateRegistered + "," + newAccount.AccountType + "," + newAccount.Balance;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(FilePath, true))
            {
                file.WriteLine(data);
            }
        }
    }
}
