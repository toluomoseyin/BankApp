using BankApp.Models1;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Core1
{
    public interface ITransactionRepository
    {
        public bool AddTransaction(Transaction model);
       
    }
}
