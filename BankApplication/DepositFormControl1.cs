using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Core1;
using BankApp.Models1;
//using BankApplication.Core1;

namespace BankApplication
{
    public partial class DepositFormControl1 : UserControl
    {
        private readonly IAccountRepository _accountRepository;
        private readonly Label label;
        public DepositFormControl1(IAccountRepository accountRepository, Label _label)
        {
            label = _label;
            _accountRepository = accountRepository;
            InitializeComponent();
        }

        private void WithdrawFormControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string amount = WithdrawAmountText.Text;
                string note = WithdrawNoteText.Text;
                string AcctNumber = WithdrawAcctNumText.Text;

                if (!(string.IsNullOrWhiteSpace(AcctNumber) || string.IsNullOrWhiteSpace(note) || string.IsNullOrWhiteSpace(amount)))
                {
                    if (Utilities.IsDigitsOnly(amount) || Utilities.IsDigitsOnly(AcctNumber))
                    {
                       if(MakeDeposit(AcctNumber, decimal.Parse(amount), note))
                        {
                            label.Text = "#" + _accountRepository.GetAccountBalance(AcctNumber).ToString();
                            WithdrawAcctNumText.Text = string.Empty;
                            WithdrawNoteText.Text = string.Empty;
                            WithdrawAcctNumText.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Account number does not Exist!");
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Amount or account number cannot be a string!");

                    }

                }
                else
                {
                    MessageBox.Show("All fields are required!");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
            bool MakeDeposit(string acc, decimal amt, string note)
            {

                try
                {
                    // validate input
                    if (string.IsNullOrWhiteSpace(acc) || string.IsNullOrWhiteSpace(note) || amt < 1)
                    {
                        throw new ArgumentNullException();
                    }

                    // get account type
                    var accType = _accountRepository.GetAccountByAccNum(acc);
                    if (accType == null)
                    {
                        return false;
                    }
                       

                    // make deposit
                    _accountRepository.MakeDeposite(acc, amt, note, accType.AccountType);
                    string message = $"Transaction Successful! Your new Balance is {_accountRepository.GetAccountBalance(acc)}";
                    MessageBox.Show(message);


                }
                catch (NullReferenceException e)
                {
                    MessageBox.Show(e.Message);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return true;
            }

            //private void textBox1_TextChanged(object sender, EventArgs e)
            //{

            //}
            
        }
}   }
