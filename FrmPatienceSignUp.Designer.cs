namespace Hospital_Project
{
    partial class FrmPatienceSignUp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatienceSignUp));
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.msktrid = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskphone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.btnsignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(225, 228);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(169, 31);
            this.txtpassword.TabIndex = 6;
            // 
            // msktrid
            // 
            this.msktrid.Location = new System.Drawing.Point(225, 154);
            this.msktrid.Mask = "00000000000";
            this.msktrid.Name = "msktrid";
            this.msktrid.Size = new System.Drawing.Size(169, 31);
            this.msktrid.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient TR ID Number:";
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(225, 80);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(169, 31);
            this.txtsurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Patient Surname:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(225, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 31);
            this.txtName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Patient Name:";
            // 
            // mskphone
            // 
            this.mskphone.Location = new System.Drawing.Point(225, 117);
            this.mskphone.Mask = "(999) 000-0000";
            this.mskphone.Name = "mskphone";
            this.mskphone.Size = new System.Drawing.Size(169, 31);
            this.mskphone.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Patient Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gender";
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.cmbgender.Location = new System.Drawing.Point(225, 191);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(169, 31);
            this.cmbgender.TabIndex = 5;
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsignup.Location = new System.Drawing.Point(255, 275);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(103, 42);
            this.btnsignup.TabIndex = 7;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // FrmPatienceSignUp
            // 
            this.AcceptButton = this.btnsignup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(445, 338);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskphone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.msktrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPatienceSignUp";
            this.Text = "Patient Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.MaskedTextBox msktrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.Button btnsignup;
    }
}