using BankApp.Models1;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Core1
{
    public interface IAccountRepository
    {
        public int RowCount { get; }

        public List<Account> GetOwnerAccounts(string id);
        public Account GetAccountByAccNum(string accNum);
        public bool AddAccount(Account model);  
        public void MakeDeposite(string accNum, decimal amt, string note, string type);
        public void MakeWithdrawal(string accNum, decimal amt, string note, string type);
        public void MakeTransfer(string senderNumber, string receiverNumber, decimal amt, string note, string type);
        public decimal GetBalance(string accountNumber);
        decimal GetAccountBalance(string acctNum);
        string GetID(string acctNum);
        decimal GetMinBalance(string acctNum);
    }
}
