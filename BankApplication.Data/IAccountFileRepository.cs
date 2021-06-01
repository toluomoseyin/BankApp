using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Models1;

namespace BankApplication1.Data
{
    public interface IAccountFileRepository
    {
        void WriteToAccountFile(Account newAccount);
    }
}
