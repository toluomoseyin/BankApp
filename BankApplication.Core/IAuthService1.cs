using BankApp.Models1;

namespace BankApp.Core1
{
    public interface IAuthServices1
    {
        public bool Register(Customer model, string password);
        public bool Login(string email, string password);
    }
}
