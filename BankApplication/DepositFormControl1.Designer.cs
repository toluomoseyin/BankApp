
namespace BankApplication
{
    partial class DepositFormControl1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WithdrawAmountText = new System.Windows.Forms.TextBox();
            this.WithdrawAcctNumText = new System.Windows.Forms.TextBox();
            this.AcctNumText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.WithdrawNoteText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(29, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 401);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.WithdrawAmountText);
            this.panel2.Controls.Add(this.WithdrawAcctNumText);
            this.panel2.Controls.Add(this.AcctNumText);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.WithdrawNoteText);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(11, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 374);
            this.panel2.TabIndex = 0;
            // 
            // WithdrawAmountText
            // 
            this.WithdrawAmountText.BackColor = System.Drawing.Color.White;
            this.WithdrawAmountText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WithdrawAmountText.Location = new System.Drawing.Point(254, 146);
            this.WithdrawAmountText.Multiline = true;
            this.WithdrawAmountText.Name = "WithdrawAmountText";
            this.WithdrawAmountText.Size = new System.Drawing.Size(184, 31);
            this.WithdrawAmountText.TabIndex = 8;
            // 
            // WithdrawAcctNumText
            // 
            this.WithdrawAcctNumText.BackColor = System.Drawing.Color.White;
            this.WithdrawAcctNumText.Location = new System.Drawing.Point(254, 77);
            this.WithdrawAcctNumText.Multiline = true;
            this.WithdrawAcctNumText.Name = "WithdrawAcctNumText";
            this.WithdrawAcctNumText.Size = new System.Drawing.Size(184, 36);
            this.WithdrawAcctNumText.TabIndex = 15;
           // this.WithdrawAcctNumText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AcctNumText
            // 
            this.AcctNumText.AutoSize = true;
            this.AcctNumText.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcctNumText.ForeColor = System.Drawing.Color.DarkBlue;
            this.AcctNumText.Location = new System.Drawing.Point(56, 82);
            this.AcctNumText.Name = "AcctNumText";
            this.AcctNumText.Size = new System.Drawing.Size(184, 31);
            this.AcctNumText.TabIndex = 14;
            this.AcctNumText.Text = "Account Num  :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(324, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WithdrawNoteText
            // 
            this.WithdrawNoteText.BackColor = System.Drawing.Color.White;
            this.WithdrawNoteText.Location = new System.Drawing.Point(254, 216);
            this.WithdrawNoteText.Multiline = true;
            this.WithdrawNoteText.Name = "WithdrawNoteText";
            this.WithdrawNoteText.Size = new System.Drawing.Size(184, 36);
            this.WithdrawNoteText.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(149, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Note  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(49, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Amount  :";
            // 
            // DepositFormControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Name = "DepositFormControl1";
            this.Size = new System.Drawing.Size(689, 524);
            this.Load += new System.EventHandler(this.WithdrawFormControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox WithdrawNoteText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WithdrawAmountText;
        private System.Windows.Forms.TextBox WithdrawAcctNumText;
        private System.Windows.Forms.Label AcctNumText;
    }
}
