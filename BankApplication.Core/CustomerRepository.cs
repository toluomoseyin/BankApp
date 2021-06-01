using BankApp.Core1;
using BankApp.Models1;
using System;
using System.Collections.Generic;
using System.Text;
using BankApplication1.Data;
using BankApplication1.Data.DataBase;

namespace BankApp.Core
{
    public class CustomerRepository : ICustomerRepository
    {
        
        //DECLARING THE PARAMETERS TO BE INJECTED
        private readonly ICustomerFileRepository _FileRepository;
        private readonly IDataBaseRepository dataBaseRepository;


        // INJECTING THE CUSTOMER REPOSITORY AND DATABASE REPOSITORY IN THE CONSTRUCTOR
        public CustomerRepository(ICustomerFileRepository customerFile,IDataBaseRepository  customerData)
        {
            _FileRepository = customerFile;
            dataBaseRepository = customerData;
           
        }




        // ADDS A USER BOTH TO THE FILE AND DATABASE SIMULTANEOUSLY
        public bool AddUser(Customer model)
        {
            model.Id = Guid.NewGuid().ToString();
            _FileRepository.WriteToCustomerFile(model);
            dataBaseRepository.WriteCustomerToDataBase(model);
            return true;
        }



        // THIS METHOD GETS A USER USING THE USER EMAIL
        public Customer GetUser(string email)
        {
            foreach (var row in dataBaseRepository.GetCustomer())
            {
                if (row.Email == email)
                {
                    var userToReturn = new Customer
                    {
                        Id = row.Id,
                        Name = row.Name,
                        Email = row.Email,
                        DateRegistered = row.DateRegistered
                    };
                    return userToReturn;
                }
            }

            return null;
        }

     
    }
}
