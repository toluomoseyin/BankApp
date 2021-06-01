//using BankApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class AccountDetailsForm : UserControl
    {
        public AccountDetailsForm()
        {
            InitializeComponent();
        }
        //  This is showing the account details of the customer
        private void button1_Click(object sender, EventArgs e)
        {
            //var AcctNum = acctText.Text;
            //string k =WritingReadingFile.accountdetail(AcctNum);
            //BankDetail.Items.Add(new ListViewItem(new string[]
            //    {
            //        k.Split(",")[2],k.Split(",")[0],k.Split(",")[5],k.Split(",")[4]
            //    }));
        }

        private void BankDetail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
