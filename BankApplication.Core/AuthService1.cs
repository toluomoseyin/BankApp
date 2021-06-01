//using BankApp.Data1;
using BankApp.Models1;
using BankApplication1.Data.DataBase;
using System;

namespace BankApp.Core1
{
    public class AuthService : IAuthServices1
    {

        //DECLARING THE PARAMETERS TO BE INJECTED
        private readonly ICustomerRepository _userRepository;
        private readonly IDataBaseRepository _dataBaseRepository;



        // INJECTING CUSTOMER REPOSITORY AND DATABASE REPOSITORY IN THE CONSTRUCTOR
        public AuthService(ICustomerRepository userRepository,IDataBaseRepository dataBaseRepository)
        {
            _dataBaseRepository = dataBaseRepository;
            _userRepository = userRepository;
        }


        // THIS METHOD GENERATES HASH AND SALT FOR A PASSWORD AND ADDS TO CUSTOMER
        public bool Register(Customer model, string password)
        {
            var hashes = Utilities.GenerateHash(password);
            model.PasswordHash = hashes[0];
            model.PasswordSalt = hashes[1];
            _userRepository.AddUser(model);
            return true;
        }


        //THIS METHOD CHECKS IF THE EMAIL AND PASSWORD A USER ENTERS MATCHES ANY IN THE DATA BASE
        public bool Login(string email, string password)
        {
            foreach (var user in _dataBaseRepository.GetCustomer())
            {
                if (user.Email == email)
                {
                    if (Utilities.CompareHash(user.PasswordSalt, user.PasswordHash, password))
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        
    }
}
