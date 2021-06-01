//using BankApp.Models1;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace BankApp.Data1
//{
//    public static class DataSource
//    {
//        public static List<Customer> UsersTbl { get; set; } = new List<Customer>();
//        public static List<Account> AccountTbl { get; set; } = new List<Account>();
//        public static List<Transaction> TransactionTbl { get; set; } = new List<Transaction>();

//        public static List<Customer> ReadFromCustomerFile()
//        {
//            List<Customer> Customers = new List<Customer>();
//            string[] k;
//            string Path = @"C:\Users\hp\Desktop\new one\BankApplication.Data\DataBaseFiles\Customer.txt";
//            var AllCustomer = File.ReadAllLines(Path).ToList();
//            foreach (var lines in AllCustomer)
//            {
//                k = lines.Split(",");
//                var customer = new Customer
//                {
//                    Email = k[0],
//                    Name = k[1],
//                    Id = k[2],
//                    Address = k[3],
//                    Phone = k[4],
//                    PasswordHash = Convert.FromBase64String( k[5]),
//                    PasswordSalt= Convert.FromBase64String(k[6]),
//                    DateRegistered = DateTime.Parse(k[7])
//                };
//                Customers.Add(customer);
//            }
//            return Customers;
//        }

//        public static List<Account> ReadFromAccountFile()
//        {
//            List<Account> Accounts = new List<Account>();
//            string[] k;
//            string Path = @"C:\Users\hp\Desktop\new one\BankApplication.Data\DataBaseFiles\Accounts.txt";
//            var AllAccounts = File.ReadAllLines(Path).ToList();
//            foreach (var lines in AllAccounts)
//            {
//                k = lines.Split(",");
//                var account = new Account
//                {
//                    AccountNumber = k[0],
//                    OwnerId = k[1],
//                    DateRegistered = DateTime.Parse(k[2]),
//                    AccountType = k[3],
                    
//                    Balance = decimal.Parse(k[4])    
//                };
//                Accounts.Add(account);
//            }
//            return Accounts;
//        }

//        public static List<Transaction> ReadFromTransactionFile()
//        {
//            List<Transaction> Transactions = new List<Transaction>();
//            string[] k;
//            string Path = @"C:\Users\hp\Desktop\new one\BankApplication.Data\DataBaseFiles\Transactions.txt";
//            var AllTransaction = File.ReadAllLines(Path).ToList();
//            foreach (var lines in AllTransaction)
//            {
//                k = lines.Split(",");
//                var transaction = new Transaction
//                {
//                    TypeOfTransaction = k[0],
//                    TypeOfAccount = k[1],
//                    Amount = Decimal.Parse(k[2]),
//                    DateOfTransaction = DateTime.Parse(k[3]),
//                    Note = k[4],
//                    Id = k[5],
//                    AccountNumber = k[6],
//                    AcctBalance =decimal.Parse( k[7])
//                };
//                Transactions.Add(transaction);
//            }
//            return Transactions;
//        }

//    }
//}
