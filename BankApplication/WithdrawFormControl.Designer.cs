
namespace BankApplication
{
    partial class WithdrawFormControl
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
            this.DepositAmountText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DepositNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DepositAccnumText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepositAmountText
            // 
            this.DepositAmountText.BackColor = System.Drawing.Color.White;
            this.DepositAmountText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepositAmountText.Location = new System.Drawing.Point(240, 145);
            this.DepositAmountText.Multiline = true;
            this.DepositAmountText.Name = "DepositAmountText";
            this.DepositAmountText.Size = new System.Drawing.Size(242, 31);
            this.DepositAmountText.TabIndex = 14;
            this.DepositAmountText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(49, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 401);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.DepositNote);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DepositAccnumText);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.DepositAmountText);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(11, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 375);
            this.panel2.TabIndex = 0;
            // 
            // DepositNote
            // 
            this.DepositNote.BackColor = System.Drawing.Color.White;
            this.DepositNote.Location = new System.Drawing.Point(240, 205);
            this.DepositNote.Multiline = true;
            this.DepositNote.Name = "DepositNote";
            this.DepositNote.Size = new System.Drawing.Size(242, 36);
            this.DepositNote.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(147, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Note  :";
            // 
            // DepositAccnumText
            // 
            this.DepositAccnumText.BackColor = System.Drawing.Color.White;
            this.DepositAccnumText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepositAccnumText.Location = new System.Drawing.Point(240, 83);
            this.DepositAccnumText.Multiline = true;
            this.DepositAccnumText.Name = "DepositAccnumText";
            this.DepositAccnumText.Size = new System.Drawing.Size(242, 31);
            this.DepositAccnumText.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(47, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Enter Amount  :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(385, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(14, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Account Number  :";
            // 
            // WithdrawFormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "WithdrawFormControl";
            this.Size = new System.Drawing.Size(656, 536);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox DepositAmountText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DepositNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DepositAccnumText;
        private System.Windows.Forms.Label label4;
    }
}
