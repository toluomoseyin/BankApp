using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models1;
using System.Data.SqlClient;

namespace BankApplication1.Data.DataBase
{
    public class DataBaseRepository:IDataBaseRepository
    {
        //DECLARES THE CONNECTION STRING
        public string ConnectString  = "Data Source=.;Initial Catalog = BankApplication; Integrated Security = True";
        


        // WRITES THE CUSTOMER DETAILS INTO THE CUSTOMER TABLE IN THE DATABASE
        public bool WriteCustomerToDataBase(Customer customer)
        {
            SqlConnection con = new SqlConnection(ConnectString);
            string Query = "Insert into CustomerTable (ID,Name,Email,Phone,Address,PasswordHash,PasswordSalt,DateRegistered)  values(@_ID,@_Name,@_Email,@_Phone,@_Address,@_PasswordHash,@_PasswordSalt,@_DateRegistered)";
            SqlCommand command = new SqlCommand(Query, con);
            command.Parameters.AddWithValue("@_ID",customer.Id);
            command.Parameters.AddWithValue("@_Name",customer.Name);
            command.Parameters.AddWithValue("@_Email",customer.Email);
            command.Parameters.AddWithValue("@_Phone",customer.Phone);
            command.Parameters.AddWithValue("@_Address",customer.Address);
            command.Parameters.AddWithValue("@_PasswordHash",Convert.ToBase64String(customer.PasswordHash));
            command.Parameters.AddWithValue("@_PasswordSalt",Convert.ToBase64String(customer.PasswordSalt));
            command.Parameters.AddWithValue("@_DateRegistered",customer.DateRegistered.ToString());
            con.Open();
            int i = command.ExecuteNonQuery();
            if (i > 0)
            {
                return true;
            }
            return false;
            
        }

        //WRITES ACCOUNT TO THE DATA BASE
        public bool WriteAccountToDataBase(Account account)
        {
            SqlConnection con = new SqlConnection(ConnectString);
            string Query = "Insert into AccountTable (ID,AccountNumber,DateRegistered,AccountType,Balance)  values(@_ID,@_AccountNumber,@_DateRegistered,@_AccountType,@_Balance)";
            SqlCommand command = new SqlCommand(Query, con);
            command.Parameters.AddWithValue("@_ID", account.OwnerId);
            command.Parameters.AddWithValue("@_AccountNumber", account.AccountNumber);
            command.Parameters.AddWithValue("@_DateRegistered", account.DateRegistered);
            command.Parameters.AddWithValue("@_AccountType", account.AccountType);
            command.Parameters.AddWithValue("@_Balance", account.Balance);
            con.Open();
            int i = command.ExecuteNonQuery();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //WRITES ALL TRANSACTION TO THE DATABASE
        public bool WriteTransactionToDataBase(Transaction transaction)
        {
            SqlConnection con = new SqlConnection(ConnectString);
            string Query = "Insert into TransactionTable (ID,TypeOfTransaction,TypeOfAccount,Amount,DateOfTransaction,Note,AccountNumber,AccountBalance)  values(@_ID,@_TypeOfTransaction,@_TypeOfAccount,@_Amount,@_DateOfTransaction,@_Note,@_AccountNumber,@_AccountBalance)";
            SqlCommand command = new SqlCommand(Query, con);
            command.Parameters.AddWithValue("@_ID", transaction.Id);
            command.Parameters.AddWithValue("@_TypeOfTransaction", transaction.TypeOfTransaction);
            command.Parameters.AddWithValue("@_TypeOfAccount", transaction.TypeOfAccount);
            command.Parameters.AddWithValue("@_Amount", transaction.Amount);
            command.Parameters.AddWithValue("@_DateOfTransaction", transaction.DateOfTransaction);
            command.Parameters.AddWithValue("@_Note", transaction.Note);
            command.Parameters.AddWithValue("@_AccountNumber", transaction.AccountNumber);
            command.Parameters.AddWithValue("@_AccountBalance", transaction.AcctBalance);
            con.Open();
            int i = command.ExecuteNonQuery();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       

        // GET CUSTOMERS FROM THE DATABASE
        public List<Customer> GetCustomer()
        {
            List<Customer> CustomerAccounts = new List<Customer>();
            SqlConnection con = new SqlConnection(ConnectString);
            con.Open();
            var query = "SELECT * FROM CustomerTable";
            SqlCommand command = new SqlCommand(query, con);
           
            SqlDataReader a = command.ExecuteReader();   
            while (a.Read())
            {
                var customer = new Customer
                {
                    Email = (string)a["Email"],
                    Name = (string)a["Name"],
                    Id = (string)a["ID"],
                    Address = (string)a["Address"],
                    Phone = (string)a["Phone"],
                    PasswordHash = Convert.FromBase64String((string)a["PasswordHash"]),
                    PasswordSalt = Convert.FromBase64String((string)a["PasswordSalt"]),
                    DateRegistered = DateTime.Parse((string)a["DateRegistered"])
                };
                CustomerAccounts.Add(customer);
            }

            return CustomerAccounts;
         

        }




        //GETS THE ACCOUNT FROM THE DATABASE
        public List<Account> GetAccount()
        {
            List<Account> Accounts = new List<Account>();
            SqlConnection con = new SqlConnection(ConnectString);
            con.Open();
            var sql = "SELECT * FROM AccountTable";
            SqlCommand cmd = new SqlCommand(sql, con);
           
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                var account = new Account
                {
                    OwnerId = (string)sdr["ID"],
                    AccountNumber = (string)sdr["AccountNumber"],
                    DateRegistered = DateTime.Parse((string)sdr["DateRegistered"]),
                    AccountType = (string)sdr["AccountType"],
                   Balance = Decimal.Parse((string)sdr["Balance"])              
                };
                Accounts.Add(account);
            }

            return Accounts;
        }





        //READS THE TRANSACTION FROM THE DATABSASE
        public List<Transaction> GetTransaction(string id)
        {
            List<Transaction> Transactions = new List<Transaction>();
            SqlConnection con = new SqlConnection(ConnectString);
            con.Open();
            var sql = "SELECT * FROM TransactionTable WHERE ID = @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                var transaction = new Transaction
                {
                    Id = (string)sdr["ID"],
                    
                    TypeOfTransaction = (string)sdr["TypeOfTransaction"],
                    TypeOfAccount = (string)sdr["TypeOfAccount"],
                    Amount = Decimal.Parse((string)sdr["Amount"]),
                    DateOfTransaction = DateTime.Parse((string)sdr["DateOfTransaction"]),
                    Note = (string)sdr["Note"],
                    AccountNumber = (string)sdr["AccountNumber"],
                    AcctBalance = Convert.ToDecimal((string)sdr["AccountBalance"])

                };
                Transactions.Add(transaction);
            }

            return Transactions;
        }

        
    }
}
