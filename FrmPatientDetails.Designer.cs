namespace Hospital_Project
{
    partial class FrmPatientDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientDetails));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblnamesurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lnkeditinfo = new System.Windows.Forms.LinkLabel();
            this.btnappointment = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rchproblems = new System.Windows.Forms.RichTextBox();
            this.cmbdoctor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbbranch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblnamesurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient`s Info";
            // 
            // lblnamesurname
            // 
            this.lblnamesurname.AutoSize = true;
            this.lblnamesurname.Location = new System.Drawing.Point(158, 96);
            this.lblnamesurname.Name = "lblnamesurname";
            this.lblnamesurname.Size = new System.Drawing.Size(76, 23);
            this.lblnamesurname.TabIndex = 3;
            this.lblnamesurname.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name Surname:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(158, 61);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(120, 23);
            this.lblTC.TabIndex = 1;
            this.lblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TR ID Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lnkeditinfo);
            this.groupBox2.Controls.Add(this.btnappointment);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rchproblems);
            this.groupBox2.Controls.Add(this.cmbdoctor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbbranch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(30, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 327);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Info";
            // 
            // lnkeditinfo
            // 
            this.lnkeditinfo.AutoSize = true;
            this.lnkeditinfo.Location = new System.Drawing.Point(14, 284);
            this.lnkeditinfo.Name = "lnkeditinfo";
            this.lnkeditinfo.Size = new System.Drawing.Size(184, 23);
            this.lnkeditinfo.TabIndex = 5;
            this.lnkeditinfo.TabStop = true;
            this.lnkeditinfo.Text = "Edit Your Informations";
            this.lnkeditinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkeditinfo_LinkClicked);
            // 
            // btnappointment
            // 
            this.btnappointment.Location = new System.Drawing.Point(82, 235);
            this.btnappointment.Name = "btnappointment";
            this.btnappointment.Size = new System.Drawing.Size(196, 35);
            this.btnappointment.TabIndex = 4;
            this.btnappointment.Text = "Make an Appoinment";
            this.btnappointment.UseVisualStyleBackColor = true;
            this.btnappointment.Click += new System.EventHandler(this.btnappointment_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Problems:";
            // 
            // rchproblems
            // 
            this.rchproblems.Location = new System.Drawing.Point(109, 121);
            this.rchproblems.Name = "rchproblems";
            this.rchproblems.Size = new System.Drawing.Size(152, 108);
            this.rchproblems.TabIndex = 3;
            this.rchproblems.Text = "";
            // 
            // cmbdoctor
            // 
            this.cmbdoctor.FormattingEnabled = true;
            this.cmbdoctor.Location = new System.Drawing.Point(109, 84);
            this.cmbdoctor.Name = "cmbdoctor";
            this.cmbdoctor.Size = new System.Drawing.Size(152, 31);
            this.cmbdoctor.TabIndex = 2;
            this.cmbdoctor.SelectedIndexChanged += new System.EventHandler(this.cmbdoctor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Doctor:";
            // 
            // cmbbranch
            // 
            this.cmbbranch.FormattingEnabled = true;
            this.cmbbranch.Location = new System.Drawing.Point(109, 47);
            this.cmbbranch.Name = "cmbbranch";
            this.cmbbranch.Size = new System.Drawing.Size(152, 31);
            this.cmbbranch.TabIndex = 1;
            this.cmbbranch.SelectedIndexChanged += new System.EventHandler(this.cmbbranch_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Branch:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(364, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 256);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 226);
            this.dataGridView1.TabIndex = 6;
//            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(364, 289);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(402, 240);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active Appointments";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(396, 210);
            this.dataGridView2.TabIndex = 7;
            // 
            // FrmPatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(776, 558);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPatientDetails";
            this.Text = "Patient Details";
            this.Load += new System.EventHandler(this.FrmPatientDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblnamesurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rchproblems;
        private System.Windows.Forms.ComboBox cmbdoctor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbbranch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnappointment;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel lnkeditinfo;
    }
}