using BankApp.Models1;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Core1
{
    public interface ICustomerRepository
    {
       
        public bool AddUser(Customer model);
       
        public Customer GetUser(string email);
    }
}
