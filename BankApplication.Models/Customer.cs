using System;
using System.Collections.Generic;


namespace BankApp.Models1
{
    public class Customer
    {
        // class properties declaration
        public string Id { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public DateTime DateRegistered { get; set; } = DateTime.Now;
        public List<Account> Accounts { get; set; }

        // empty constructor
        public Customer()
        {
            this.Accounts = new List<Account>();
            this.DateRegistered = DateTime.Now;
        }

        // constructor
        public Customer(string Name, string Email, byte[] passwordHash, byte[] passwordSalt,string phone,string address) : this()
        {
            this.Name = Name;
            this.Email = Email;
            this.PasswordHash = passwordHash;
            this.PasswordSalt = passwordSalt;
            this.Phone = phone;
            this.Address = address;
        }

    }
}
