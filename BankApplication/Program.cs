using BankApp.Core1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankApplication1.Data.DataBase;

namespace BankApplication
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // CREATING AN THE GENERAL INSTANCE ON THE PROGRAM CLASS TO SET ALL THE INJECTION
            GlobalConfig.AddInstance();
            ICustomerRepository customerConfig = GlobalConfig._customerRepository;
            IAccountRepository accountConfig = GlobalConfig._accountRepository;
            IAuthServices1 authConfig = GlobalConfig._authServiceRepository;
            ITransactionRepository transConfig = GlobalConfig._transactionRepository;
            IDataBaseRepository _dataBaseRepository = GlobalConfig._dataBaseRepository;

            // PASSING VALUES INTO THE LOG IN FORM FOR INJECTION
            Application.Run(new LoginForm(accountConfig,customerConfig,transConfig, _dataBaseRepository,authConfig));
            

        }
    }
}
