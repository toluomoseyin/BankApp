using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using BankApp.Core;
using BankApp.Core1;
using BankApp.Models1;
using BankApplication1.Data.DataBase;
//using BankApplication.Data;
namespace BankApplication
{
    public partial class LoginForm : Form
    {
        public  readonly ICustomerRepository _customerRepository;
        private readonly IAccountRepository _acctRepo;
        private readonly ITransactionRepository _transRepo;
        private readonly IAuthServices1 _authRepo;
        public string loggedInUserId;
        public string[] profile = new string[2];
        public bool loginState = false;
        private readonly IDataBaseRepository _dataBaseRepository;

        public LoginForm(IAccountRepository acctRepo,ICustomerRepository custRepo,ITransactionRepository TransRepo, IDataBaseRepository dataBaseRepository,  IAuthServices1 authRepo)
        {
            _dataBaseRepository = dataBaseRepository;
            _customerRepository = custRepo;
            _transRepo = TransRepo;
            _acctRepo = acctRepo;
            _authRepo = authRepo;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i <4; i++)
            {
                sum += i;
            }
            label9.Text = sum.ToString() ;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        public  void button2_Click(object sender, EventArgs e)
        {
             this.Hide();
            AccounRegistrationForm newForm = new AccounRegistrationForm(_acctRepo, _customerRepository,_transRepo,_dataBaseRepository,  _authRepo);
            newForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Email = EmailText.Text;
            string Password = PasswordText.Text;
            var LoggedInUser = this.Login(Email, Password);
            if (LoggedInUser[0] != null)
            {
                string message = "Login Succesful!";
                MessageBox.Show(message);
                this.Hide();
                CustomerDashBoardForm tolu = new CustomerDashBoardForm(_acctRepo, _customerRepository, _transRepo, _dataBaseRepository, _authRepo, LoggedInUser);
                tolu.Show();
            }
            EmailText.Text = string.Empty;
            PasswordText.Text = string.Empty;


        }
        public string[] Login(string email, string password)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    throw new ArgumentNullException("All Fields Are Required !");
                }

                if (!Utilities.IsEmailValid(email))
                {
                    throw new FormatException("This Email is not in the correct format !");
                }

                // login using the auth service
                if (_authRepo.Login(email, password))
                {
                    var user = _customerRepository.GetUser(email);
                    // if (email)
                    loggedInUserId = user.Id;

                    // get username and account numbers
                    var ownerAccounts = _acctRepo.GetOwnerAccounts(user.Id);
                    string accs = "";
                    foreach (var acc in ownerAccounts)
                    {
                        accs = acc.AccountNumber;
                    }

                    profile[0] = user.Name;
                    profile[1] = accs;
                }
                else
                {
                    throw new Exception("This user is not registered ! \n Please create an account !");
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show( ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return profile;

        }



        private void tolu_Click(object sender, EventArgs e)
        {

        }

        
    }
}
