using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Core1;
using BankApp.Models1;
//using BankApplication.Core;

namespace BankApplication
{
    public partial class WithdrawFormControl : UserControl
    {
        private readonly IAccountRepository _accountRepository;
        private readonly Label label;
        public WithdrawFormControl(IAccountRepository accountRepository,Label _label_)
        {
            label = _label_;
            _accountRepository = accountRepository;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // This deposits into the account
        private void button1_Click(object sender, EventArgs e)
        {
            var acctNum = DepositAccnumText.Text;
            var note = DepositNote.Text;
            var amount = DepositAmountText.Text;
            if (!(string.IsNullOrWhiteSpace(acctNum) || string.IsNullOrWhiteSpace(note) || string.IsNullOrWhiteSpace(amount))){
                if (Utilities.IsDigitsOnly(amount)|| Utilities.IsDigitsOnly(acctNum))
                {
                    if(Withdraw(acctNum, decimal.Parse(amount), note))
                    {
                        label.Text = "#" + _accountRepository.GetAccountBalance(acctNum).ToString();
                        DepositAccnumText.Text = string.Empty;
                        DepositNote.Text = string.Empty;
                        DepositAmountText.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Account number does not exist !");
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

        public bool Withdraw(string acc, decimal amt, string note)
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

                _accountRepository.MakeWithdrawal(acc, amt, note, accType.AccountType);
                
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
    }
}
