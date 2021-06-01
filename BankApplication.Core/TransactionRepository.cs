using BankApp.Core1;
//using BankApp.Data1;
using BankApp.Models1;
using System;
using System.Collections.Generic;
using System.Text;
using BankApplication1.Data;
using BankApplication1.Data.DataBase;

namespace BankApp.Core
{
    public class TransactionRepository : ITransactionRepository
    {

        //DECLARING THE PARAMETERS TO BE INJECTED
        public int RowCount { get; private set; }
        private readonly ITransactionFileRepository _transactionFileRepository;
        private readonly IDataBaseRepository _dataBaseRepository;


        //INJECTECTING THE TRANSACTION FILE REPOSITORY AND DATABASE REPOSITORY IN THE CONSTRUCTOR
        public TransactionRepository(ITransactionFileRepository transactionFileRepository, IDataBaseRepository dataBaseRepository)
        {
            _transactionFileRepository = transactionFileRepository;
            _dataBaseRepository = dataBaseRepository;
           
        }


        // THIS METHOD ADDS ALL TRANSACTION TO FILE AND DATABASE SIMULTANEOUSLY
        public bool AddTransaction(Transaction model)
        {  
            _transactionFileRepository.WriteToTransactionFile(model);
            _dataBaseRepository.WriteTransactionToDataBase(model);
            return true;
        }



    }
}
