namespace Hospital_Project
{
    partial class Frm_PatientEntrance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PatientEntrance));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msktrid = new System.Windows.Forms.MaskedTextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lnkSignup = new System.Windows.Forms.LinkLabel();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Entrance Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient TR ID Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // msktrid
            // 
            this.msktrid.Location = new System.Drawing.Point(241, 154);
            this.msktrid.Mask = "00000000000";
            this.msktrid.Name = "msktrid";
            this.msktrid.Size = new System.Drawing.Size(169, 31);
            this.msktrid.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(241, 194);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(169, 31);
            this.txtpassword.TabIndex = 2;
            // 
            // lnkSignup
            // 
            this.lnkSignup.AutoSize = true;
            this.lnkSignup.Location = new System.Drawing.Point(436, 197);
            this.lnkSignup.Name = "lnkSignup";
            this.lnkSignup.Size = new System.Drawing.Size(70, 23);
            this.lnkSignup.TabIndex = 3;
            this.lnkSignup.TabStop = true;
            this.lnkSignup.Text = "Sign Up";
            this.lnkSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignup_LinkClicked);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(274, 243);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(105, 39);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Frm_PatientEntrance
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(542, 340);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lnkSignup);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.msktrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PatientEntrance";
            this.Text = "Patient Entrance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msktrid;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.LinkLabel lnkSignup;
        private System.Windows.Forms.Button btnEnter;
    }
}