
//using BankApp.Data1;
using BankApp.Models1;
using System;
using System.Collections.Generic;
using System.Text;
using BankApplication1.Data;
using BankApplication1.Data.DataBase;

namespace BankApp.Core1
{
    class AccountRepository : IAccountRepository
    {
        //DECLARING THE PARAMETERS TO BE INJECTED
        public int RowCount { get; private set; }

        private int accountNumberSeed = 1234567890;
        private readonly ITransactionRepository _transRepository;
        private readonly IAccountFileRepository _accounFileRepository;
        private readonly IDataBaseRepository _dataBaseRepository;
        

        // INJECTING TRANSACTION REPOSITORY, ACCOUNTFILE REPOSITORY AND DATABASE REPOSITORY IN THE ACCOUNT REPOSITORY
        public AccountRepository(ITransactionRepository transactionRepository,IAccountFileRepository accountFileRepository, IDataBaseRepository dataBaseRepository)
        {

            //RowCount = DataSource.ReadFromAccountFile().Count;
            _transRepository = transactionRepository;
            _accounFileRepository = accountFileRepository;
            _dataBaseRepository = dataBaseRepository;
        }

        //THIS METHOD GETS AN ACCOUNT USING AN ID
        public List<Account> GetOwnerAccounts(string id)
        {
            var accts = new List<Account>();
            foreach (var acct in _dataBaseRepository.GetAccount())
            {
                if (acct.OwnerId == id)
                    accts.Add(acct);
            }
            return accts;
        }
        

        // THIS METHOD GENERATE ACCOUNT NUMBER ADDS AN ACCOUNT TO FILE AND TO THE DATABASE SIMULTANEOUSLY
        public bool AddAccount(Account model)
        {
            model.AccountNumber = this.GenerateAccountNum().ToString();
            _accounFileRepository.WriteToAccountFile(model);
            _dataBaseRepository.WriteAccountToDataBase(model);
            return true;
        }
        
        //THIS METHOD GENERATES ACCOUNT NUMBERS
        private int GenerateAccountNum()
        {
            accountNumberSeed += this.RowCount; 
            return accountNumberSeed;
        }



        // THIS METHOD MAKES DEPOSIT IN THE ACCOUNT 
        public void MakeDeposite(string accNum, decimal amt, string note, string type)
        {
            if (amt < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amt), "Deposit amount must be positive");
            }
            Transaction deposit = new Transaction(accNum, amt, note, type);
            deposit.TypeOfTransaction = "Deposit";
            deposit.Id = GetID(accNum);
            deposit.AcctBalance = GetAccountBalance(accNum) + amt;
            _transRepository.AddTransaction(deposit);
        }

        public void MakeWithdrawal(string accNum, decimal amt, string note, string type)
        {
            // ensure the amount is not less than zero
            if (amt < 0)
                throw new ArgumentOutOfRangeException(nameof(amt), "Deposit amount must be positive");

            var bal = GetAccountBalance(accNum);

            // ensure the amount left after withdrawals for savings don't got below 100
            if (type == "Savings" && bal - amt < 1000)
                throw new InvalidOperationException("You don't have sufficient fund for this operation");

            // ensure the amount left after withdrawals for savings don't got below 1000
            if (type == "Current" && bal - amt < 0)
                throw new InvalidOperationException("You don't have sufficient fund for this operation");

            // add a new deposit
             Transaction withdrawal = new Transaction(accNum, -amt, note, type);
             withdrawal.TypeOfTransaction = "withdrawal";
             withdrawal.Id = GetID(accNum);
             withdrawal.AcctBalance = GetAccountBalance(accNum) -amt;
             _transRepository.AddTransaction(withdrawal);
        }

        public void MakeTransfer(string OwnerAccountNum, string BeneficiaryAcctNum, decimal amt, string note, string type)
        {
           
            if (amt < 0)
                throw new ArgumentOutOfRangeException(nameof(amt), "Transfer amount must be positive");

            // ensure number exists
            if (!NumberExists(BeneficiaryAcctNum))
                throw new InvalidOperationException("The Beneficiary account number is not registered with this bank !");

            // ensure that the sender number and the receiver nuver is not the same
            if (OwnerAccountNum == BeneficiaryAcctNum)
                throw new InvalidOperationException("Transfer amount within same account is not allowed!");

            // withdraw from the sender and deposit to the receiver
            Transaction deposit = new Transaction(BeneficiaryAcctNum, amt, note, type);
            deposit.TypeOfTransaction = "Deposit";
            deposit.Id = GetID(BeneficiaryAcctNum);
            deposit.AcctBalance = GetAccountBalance(BeneficiaryAcctNum) + amt;
            _transRepository.AddTransaction(deposit);
            Transaction withdrawal = new Transaction(OwnerAccountNum, -amt, note, type);
            withdrawal.TypeOfTransaction = "Transfer";
            withdrawal.Id = GetID(OwnerAccountNum);
            withdrawal.AcctBalance = GetAccountBalance(OwnerAccountNum) - amt;
            _transRepository.AddTransaction(withdrawal);
        }

        // THIS METHOD CHECKS IF AN ACCOUNT NUMBER EXISTS
        private bool NumberExists(string receiverNumber)
        {
            foreach (var account in _dataBaseRepository.GetAccount())
            {
                if (account.AccountNumber == receiverNumber)
                {
                    return true;
                }
            }
            return false;
        }


        // THIS METHOD GETS THE ACCOUNT BALANCE OF THE ACCOUNT
        public decimal GetBalance(string accountNumber)
        {
           
            decimal bal = 0;
            foreach (var row in _dataBaseRepository.GetTransaction(GetID( accountNumber)))
            {
                    bal += row.Amount;
            }
            return bal;
        }


        // THIS METHOD GETS THE A USER ACCOUNT USING THE ACCOUNT NUMBER
        public Account GetAccountByAccNum(string accNum)
        {

            foreach (var acct in _dataBaseRepository.GetAccount())
            {
                if (acct.AccountNumber == accNum)
                    return acct;
            }
            return null;
        }
        

        // THIS METHOD GETS THE MINIMUM BALANCE FROM AN ACCOUNT
        public decimal GetMinBalance(string acctNum)
        {
            decimal minBalance;
            foreach (var acct in _dataBaseRepository.GetAccount())
            {
                if (acct.AccountNumber == acctNum)
                {
                    minBalance = acct.Balance;
                    return minBalance;

                }

            }
            return 0;
        }
        


        // THIS METHOD GETS THE ID OF A CUSTOMER USING THE ACCOUNT NUMBER
        public string GetID(string acctNum)
        {
            string Id;
            foreach (var acct in _dataBaseRepository.GetAccount())
            {
                if (acct.AccountNumber == acctNum)
                {
                    Id = acct.OwnerId;
                    return Id;
                }

            }
            return "";
        }


        //THIS METHOD GETS THE ACCOUNT BALANCE OF A CUSTOMER
        public decimal GetAccountBalance(string acctNum)
        {
            Decimal Total = GetBalance(acctNum) + GetMinBalance(acctNum);
            return Total;
        }
    }
}
