using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models1;

namespace BankApplication1.Data.DataBase
{
    public interface IDataBaseRepository
    {
        bool WriteCustomerToDataBase(Customer customer);
        bool WriteAccountToDataBase(Account account);
        bool WriteTransactionToDataBase(Transaction transaction);
        List<Customer> GetCustomer();
        //int CountCustomerRows();
        //int CountAccountRows();
        //int CountTransactionRows();
        List<Account> GetAccount();
        List<Transaction> GetTransaction(string id);
    }
}
