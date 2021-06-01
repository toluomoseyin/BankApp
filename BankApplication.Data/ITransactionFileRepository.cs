using BankApp.Models1;

namespace BankApplication1.Data
{
    public interface ITransactionFileRepository
    {
        void WriteToTransactionFile(Transaction newAccount);
    }
}