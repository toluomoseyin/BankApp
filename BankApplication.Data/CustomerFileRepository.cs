using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models1;

namespace BankApplication1.Data
{
    public class CustomerFileRepository:ICustomerFileRepository
    {
        public CustomerFileRepository()
        {

        }
        // This method writes to the file with a comma
        public void WriteToCustomerFile(Customer customer)
        {
            string FilePath = @"C:\Users\hp\Desktop\Week-5 Task\BankApplication.Data\DataBaseFiles\Customer.txt";
            string data = customer.Email + "," + customer.Name + "," + customer.Id + "," + customer.Address + "," + customer.Phone + "," + Convert.ToBase64String(customer.PasswordHash) + "," + Convert.ToBase64String( customer.PasswordSalt) + "," + customer.DateRegistered;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(FilePath, true))
            {
                file.WriteLine(data);
            }
        }


    }
}
