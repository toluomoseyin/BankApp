using System;
using System.Collections.Generic;

namespace BankApp.Models1
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string OwnerId { get; set; }
        public decimal Balance { get; set; }
        public DateTime DateRegistered { get; set; }
        public List<Transaction> Transactions { get; set; }

        //constructors
        public Account()
        {
            this.Transactions = new List<Transaction>();
            this.DateRegistered = DateTime.Now;
        }

        public Account(string ownerId, string accountType, decimal initialBalance) : this()
        {
            this.OwnerId = ownerId;
            this.AccountType = accountType;
            this.Balance = initialBalance;
        }
    }
}