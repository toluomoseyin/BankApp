using BankApp.Core1;
using BankApplication1.Data.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class CustomerDashBoardForm : Form
    {
        public readonly ICustomerRepository _customerRepository;
        private readonly IAccountRepository _acctRepo;
        private readonly ITransactionRepository _transRepo;
        private readonly IAuthServices1 _authRepo;
        private readonly IDataBaseRepository _dataBaseRepository;
        private readonly string[] LoggedUser;
        public CustomerDashBoardForm(IAccountRepository acctRepo, ICustomerRepository custRepo, ITransactionRepository TransRepo, IDataBaseRepository dataBaseRepository, IAuthServices1 authRepo,string[] LoggedInUser)
        {
            
            InitializeComponent();
            _dataBaseRepository = dataBaseRepository;
            _customerRepository = custRepo;
            _transRepo = TransRepo;
            _acctRepo = acctRepo;
            _authRepo = authRepo;
            LoggedUser = LoggedInUser;
            this.UserDetails();
           

        }


        // DISPLAYS THE USER DETAILS ON THE DASHBOARD
        public void UserDetails()
        {
            UserName.Text = LoggedUser[0] + ",";
            UserName1.Text = LoggedUser[0] + ",";
            AccountNumber.Text = LoggedUser[1];

           AccountBalance.Text = "#" + _acctRepo.GetAccountBalance(LoggedUser[1]).ToString();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
           

        }

        private void LogoutButton_Click_1(object sender, EventArgs e)
        {

        }

        private void BankButton_Click(object sender, EventArgs e)
        {
            AccountDetailsForm newform = new AccountDetailsForm();
            ShowControl(newform);
        }

        private void CustomerDashBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void WithdrawButton_Click(object sender, EventArgs e)
         {
           
        }

        

        private void DepositButton_Click(object sender, EventArgs e)
        {
            
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
          
        }
        // THIS IS THE CONTROL METHOD
        public void ShowControl(Control control)
        {
            mainContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            mainContent.Controls.Add(control);
        }

        private void mainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AccountStatementButton_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TansferControlForm NewForm = new TansferControlForm(_acctRepo,AccountBalance);
            ShowControl(NewForm);
        }

        private void NewWithdrawB_Click(object sender, EventArgs e)
        {
            WithdrawFormControl NewForm = new WithdrawFormControl(_acctRepo,AccountBalance);
            ShowControl(NewForm);
        }


        //SHOWS THE DPOSIT CONTROL FORM WHEN THIS BUTTON IS CLICKED
        private void button4_Click(object sender, EventArgs e)
        {
            DepositFormControl1 newForm = new DepositFormControl1(_acctRepo,AccountBalance);
            ShowControl(newForm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BankStatementForm newform = new BankStatementForm(_acctRepo, _dataBaseRepository);
            ShowControl(newform);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm newForm = new LoginForm(_acctRepo, _customerRepository, _transRepo, _dataBaseRepository, _authRepo);
            newForm.Show();
        }

        private void AccountNumber_Click(object sender, EventArgs e)
        {

        }

        private void AccountBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
