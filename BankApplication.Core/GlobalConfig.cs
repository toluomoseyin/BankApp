using BankApp.Core;
using BankApplication1.Data;
using BankApplication1.Data.DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Core1
{
    public static class GlobalConfig
    {

        //DECLARING THE PARAMETERS TO BE INSTANTIATED
        public static ICustomerRepository _customerRepository;
        public static IAccountRepository _accountRepository;
        public static IAuthServices1 _authServiceRepository;
        public static ITransactionRepository _transactionRepository;
        public static ICustomerFileRepository _customerFileRepository;
        public static IAccountFileRepository _accountFileRepository;
        public static ITransactionFileRepository _transactionFileRepository;
        public static IDataBaseRepository _dataBaseRepository;



        public static void AddInstance()
        {

            // CREATING INSTANCES OF ALL INJECTION IN THE PROJECT AND PASSING THE RESPECTIVE INJECTIONS
            _dataBaseRepository = new DataBaseRepository();
            _transactionFileRepository = new TransactionFileRepository();
            _transactionRepository = new TransactionRepository(_transactionFileRepository,_dataBaseRepository);
            _customerFileRepository = new CustomerFileRepository();
            _accountFileRepository = new AccountFileRepository();
            _customerRepository = new CustomerRepository(_customerFileRepository, _dataBaseRepository);
            _accountRepository = new AccountRepository(_transactionRepository,_accountFileRepository,_dataBaseRepository);
            _authServiceRepository = new AuthService(_customerRepository,_dataBaseRepository);
          
        }
    }
}
