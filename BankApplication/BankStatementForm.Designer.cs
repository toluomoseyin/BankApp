
namespace BankApplication
{
    partial class BankStatementForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.acctText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BankStatement = new System.Windows.Forms.ListView();
            this.TransactionType = new System.Windows.Forms.ColumnHeader();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Balance = new System.Windows.Forms.ColumnHeader();
            this.Note = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // acctText
            // 
            this.acctText.Location = new System.Drawing.Point(131, 15);
            this.acctText.Multiline = true;
            this.acctText.Name = "acctText";
            this.acctText.PlaceholderText = "ENTER ACCOUNT NUMBER";
            this.acctText.Size = new System.Drawing.Size(365, 43);
            this.acctText.TabIndex = 0;
            this.acctText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.acctText.TextChanged += new System.EventHandler(this.acctText_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(131, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "NEXT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BankStatement
            // 
            this.BankStatement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TransactionType,
            this.Amount,
            this.Date,
            this.Balance,
            this.Note});
            this.BankStatement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BankStatement.HideSelection = false;
            this.BankStatement.Location = new System.Drawing.Point(0, 223);
            this.BankStatement.Name = "BankStatement";
            this.BankStatement.Size = new System.Drawing.Size(846, 301);
            this.BankStatement.TabIndex = 4;
            this.BankStatement.UseCompatibleStateImageBehavior = false;
            this.BankStatement.View = System.Windows.Forms.View.Details;
            this.BankStatement.SelectedIndexChanged += new System.EventHandler(this.BankStatement_SelectedIndexChanged);
            // 
            // TransactionType
            // 
            this.TransactionType.Text = "Transaction Type";
            this.TransactionType.Width = 150;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 150;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 300;
            // 
            // Balance
            // 
            this.Balance.Text = "Balance";
            this.Balance.Width = 150;
            // 
            // Note
            // 
            this.Note.Text = "Note";
            this.Note.Width = 150;
            // 
            // BankStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BankStatement);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.acctText);
            this.Name = "BankStatementForm";
            this.Size = new System.Drawing.Size(846, 524);
            this.Load += new System.EventHandler(this.BankStatementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox acctText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView BankStatement;
        private System.Windows.Forms.ColumnHeader TransactionType;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Balance;
        private System.Windows.Forms.ColumnHeader Note;
    }
}
