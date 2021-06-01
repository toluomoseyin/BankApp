using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Core1;
using BankApplication1.Data.DataBase;


namespace BankApplication
{
    public partial class BankStatementForm : UserControl
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IDataBaseRepository _dataBaseRepository;
        public BankStatementForm(IAccountRepository accountRepository,IDataBaseRepository dataBaseRepository)
        {
            _dataBaseRepository = dataBaseRepository;
            _accountRepository = accountRepository;
            InitializeComponent();
        }
              
        //        BANK TRANSACTIONS OR STATEMENT OF ACCOUNT
        private void button1_Click(object sender, EventArgs e)
        {
            var acctnum = acctText.Text;
            
            string ID = _accountRepository.GetID(acctnum);
            foreach (var a in _dataBaseRepository.GetTransaction(ID))
            {
                if (a.Id == ID)
                {
                    BankStatement.Items.Add(new ListViewItem(new string[]
               {

                    a.TypeOfTransaction,a.Amount.ToString(),a.DateOfTransaction.ToString(),a.AcctBalance.ToString(),a.Note
               }));
                }
               
            }
            acctText.Text = string.Empty;
        }

        private void BankStatementForm_Load(object sender, EventArgs e)
        {

        }

        private void BankStatement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void acctText_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
