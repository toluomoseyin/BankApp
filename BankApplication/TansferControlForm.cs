using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Core1;
using BankApp.Models1;

namespace BankApplication
{
    public partial class TansferControlForm : UserControl
    {
        private readonly IAccountRepository _accountRepository;
        private readonly Label label;
        public TansferControlForm(IAccountRepository accountRepository, Label AccountBalance)
        {
            label = AccountBalance;
            _accountRepository = accountRepository;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var BeneficiaryAcctNum = BeneAcct.Text;
            var YourAcctNum = YourAcct.Text;
            var amount = Amount.Text;
            var note = Note.Text;
            if (!(string.IsNullOrWhiteSpace(BeneficiaryAcctNum) || string.IsNullOrWhiteSpace(note) || string.IsNullOrWhiteSpace(amount) || string.IsNullOrWhiteSpace(YourAcctNum)))
            {
                if (Utilities.IsDigitsOnly(amount) && Utilities.IsDigitsOnly(YourAcctNum) && Utilities.IsDigitsOnly(BeneficiaryAcctNum))
                {
                    Transfer(YourAcctNum, BeneficiaryAcctNum, decimal.Parse(amount), note);
                    label.Text = "#" + _accountRepository.GetAccountBalance(YourAcctNum).ToString();
                    BeneAcct.Text = string.Empty;
                    YourAcct.Text = string.Empty;
                    Amount.Text = string.Empty;
                    Note.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Make sure you dont input string for number in account numbers and amount");
                   
                }

            }
            else
            {
                MessageBox.Show("All field are required!");
            }


            void Transfer(string YourAcctNum, string BeneficiaryAcctNum, decimal amt, string note)
            {

                try
                {
                    // validate input
                    if (string.IsNullOrWhiteSpace(YourAcctNum) || string.IsNullOrWhiteSpace(BeneficiaryAcctNum) || string.IsNullOrWhiteSpace(note) || amt < 1)
                    {
                        throw new ArgumentNullException();
                    }

                    // get account type
                    var accType = _accountRepository.GetAccountByAccNum(YourAcctNum);
                    if (accType == null)
                        throw new NullReferenceException();

                    // make deposit
                    _accountRepository.MakeTransfer(YourAcctNum, BeneficiaryAcctNum, amt, note, accType.AccountType);
                    string message = $"Transaction Successful! Your new Balance is {_accountRepository.GetAccountBalance(YourAcctNum)}";
                    MessageBox.Show(message);

                    // get current balance after successful deposit
                    // Console.WriteLine($"\nDeposite was successful! New Balance is {_accRepo.GetBalance(acc)}");

                }
                catch (NullReferenceException e)
                {
                    MessageBox.Show(e.Message);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            //private void label4_Click(object sender, EventArgs e)
            //{

            //}
        }
    }
}
