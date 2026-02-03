namespace Hospital_Project
{
    partial class frm_DoctorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoctorDetails));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblnamesurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnanouncement = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.rchproblemdetail = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblnamesurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Information";
            // 
            // lblnamesurname
            // 
            this.lblnamesurname.AutoSize = true;
            this.lblnamesurname.Location = new System.Drawing.Point(173, 87);
            this.lblnamesurname.Name = "lblnamesurname";
            this.lblnamesurname.Size = new System.Drawing.Size(76, 23);
            this.lblnamesurname.TabIndex = 7;
            this.lblnamesurname.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name Surname:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(173, 52);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(120, 23);
            this.lblTC.TabIndex = 5;
            this.lblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "TR ID Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchproblemdetail);
            this.groupBox2.Location = new System.Drawing.Point(21, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 142);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Detail";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(354, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 470);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 440);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnexit);
            this.groupBox4.Controls.Add(this.btnanouncement);
            this.groupBox4.Controls.Add(this.btnedit);
            this.groupBox4.Location = new System.Drawing.Point(27, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(303, 144);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quick Finds";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(9, 84);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(288, 40);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnanouncement
            // 
            this.btnanouncement.Location = new System.Drawing.Point(156, 38);
            this.btnanouncement.Name = "btnanouncement";
            this.btnanouncement.Size = new System.Drawing.Size(141, 40);
            this.btnanouncement.TabIndex = 1;
            this.btnanouncement.Text = "Announcements";
            this.btnanouncement.UseVisualStyleBackColor = true;
            this.btnanouncement.Click += new System.EventHandler(this.btnanouncement_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(9, 38);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(141, 40);
            this.btnedit.TabIndex = 0;
            this.btnedit.Text = "Edit Info ";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // rchproblemdetail
            // 
            this.rchproblemdetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchproblemdetail.Location = new System.Drawing.Point(3, 27);
            this.rchproblemdetail.Name = "rchproblemdetail";
            this.rchproblemdetail.Size = new System.Drawing.Size(307, 112);
            this.rchproblemdetail.TabIndex = 0;
            this.rchproblemdetail.Text = "";
            // 
            // frm_DoctorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(778, 502);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frm_DoctorDetails";
            this.Text = "Doctor Details";
            this.Load += new System.EventHandler(this.frm_DoctorDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblnamesurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnanouncement;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.RichTextBox rchproblemdetail;
    }
}