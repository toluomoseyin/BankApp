
namespace BankApplication
{
    partial class TansferControlForm
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
            this.BeneAcct = new System.Windows.Forms.TextBox();
            this.YourAcct = new System.Windows.Forms.TextBox();
            this.Note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(35, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 388);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BeneAcct);
            this.panel2.Controls.Add(this.YourAcct);
            this.panel2.Controls.Add(this.Note);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Amount);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(15, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 355);
            this.panel2.TabIndex = 0;
            // 
            // BeneAcct
            // 
            this.BeneAcct.BackColor = System.Drawing.Color.White;
            this.BeneAcct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BeneAcct.Location = new System.Drawing.Point(300, 45);
            this.BeneAcct.Multiline = true;
            this.BeneAcct.Name = "BeneAcct";
            this.BeneAcct.Size = new System.Drawing.Size(181, 31);
            this.BeneAcct.TabIndex = 21;
            // 
            // YourAcct
            // 
            this.YourAcct.BackColor = System.Drawing.Color.White;
            this.YourAcct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YourAcct.Location = new System.Drawing.Point(300, 97);
            this.YourAcct.Multiline = true;
            this.YourAcct.Name = "YourAcct";
            this.YourAcct.Size = new System.Drawing.Size(181, 31);
            this.YourAcct.TabIndex = 20;
            // 
            // Note
            // 
            this.Note.BackColor = System.Drawing.Color.White;
            this.Note.Location = new System.Drawing.Point(300, 193);
            this.Note.Multiline = true;
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(181, 36);
            this.Note.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(190, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Note  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(90, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Enter Amount  :";
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.Color.White;
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Amount.Location = new System.Drawing.Point(300, 149);
            this.Amount.Multiline = true;
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(181, 31);
            this.Amount.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(384, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(26, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Beneficiary Acct No  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(0, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your Account Number  :";
            // 
            // TansferControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TansferControlForm";
            this.Size = new System.Drawing.Size(689, 524);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BeneAcct;
        private System.Windows.Forms.TextBox YourAcct;
    }
}
