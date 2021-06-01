
using BankApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Models1
{
    public class Transaction
    {
        public string Id { get; set; }
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
        public string TypeOfAccount { get; set; }
        public DateTime DateOfTransaction { get; set; }
        public string TypeOfTransaction { get; set; }
        public decimal AcctBalance { get; set; }

        public Transaction()
        {
            this.DateOfTransaction = DateTime.Now;
        }

        public Transaction(string accNum, decimal amt, string note, string type) : this()
        {
            this.AccountNumber = accNum;
            this.Amount = amt;
            this.Note = note;
            this.TypeOfAccount = type;
        }

    }
}
