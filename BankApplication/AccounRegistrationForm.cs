using System;
using System.Windows.Forms;
using BankApp.Core1;
//using BankApplication.Data;
using BankApp.Models1;
using BankApplication1.Data.DataBase;

namespace BankApplication
{
    public partial class AccounRegistrationForm : Form
    {

        // DECLARING THE PARAMETERS TO BE INJECTED
        public readonly ICustomerRepository _customerRepository;
        private readonly IAccountRepository _acctRepo;
        private readonly ITransactionRepository _transRepo;
        private readonly IAuthServices1 _authRepo;
        private readonly IDataBaseRepository dataBaseRepository;
      


        // INJECTING INTO THE CONSTRUCTOR
        public AccounRegistrationForm(IAccountRepository acctRepo, ICustomerRepository custRepo, ITransactionRepository TransRepo,IDataBaseRepository _dataBaseRepository, IAuthServices1 authRepo)
        {
            dataBaseRepository = _dataBaseRepository;
            _customerRepository = custRepo;
            _transRepo = TransRepo;
            _acctRepo = acctRepo;
            _authRepo = authRepo;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var Email = EmailText.Text;
                var password = PasswordText.Text;
                var address = AddressText.Text;
                var phone = PhoneText.Text;
                var first = FirstNameText.Text;
                var accountype = AccountType.Text;
                var minDeposit = MinBalanceText.Text;
               

                //VALIDATING INPUTS
                if (!(string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(accountype) || string.IsNullOrWhiteSpace(minDeposit) || string.IsNullOrWhiteSpace(phone)))
                {
                    if (!Utilities.IsEmailValid(Email))
                    {
                        throw new FormatException("This Email is not in the correct format !");
                    }
                    if(Utilities.IsDigitsOnly(phone)|| Utilities.IsDigitsOnly(minDeposit))
                    {
                        Register(Email, password, address, phone, first, accountype, Decimal.Parse(minDeposit));
                        LoginForm newForm = new LoginForm(_acctRepo, _customerRepository, _transRepo, dataBaseRepository, _authRepo);
                        MessageBox.Show("Your Account Was Successfully Created !\n Press OK to continue");
                        this.Hide();

                        newForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("phone or minimum balance cant be string!");
                    }
                       
                }
                else
                {
                    MessageBox.Show("All Field Are Required !");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
         




        }

        public bool Register(string email, string password, string address, string phone, string name, string accountype, Decimal minDeposit)
        {
            var customer = new Customer
            {
                Name = name,
                Email = email,
                Phone = phone,
                Address = address
            };

            _authRepo.Register(customer, password);  
            var acc = new Account(_customerRepository.GetUser(email).Id, accountype, minDeposit);
            _acctRepo.AddAccount(acc);
            return true;
        }
        private void FirstNameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
