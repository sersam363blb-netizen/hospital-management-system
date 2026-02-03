using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Project
{
    public partial class frmsecretarydetails : Form
    {
        public frmsecretarydetails()
        {
            InitializeComponent();
        }

        public string trid1;
        sqlbaglantisi bgl = new sqlbaglantisi();

        public void writingdatagrid()
        {
            //Tranfer patients to datagrid
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Patients", bgl.baglanti());
            da.Fill(dt1);
            dataGridView2.DataSource = dt1;

            //Transfer Appointments to datagrid
            DataTable dt2 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Appointments", bgl.baglanti());
            da1.Fill(dt2);
            dataGridView3.DataSource = dt2;
        }
        private void frmsecretarydetails_Load(object sender, EventArgs e)
        {
            writingdatagrid();

            lblTC.Text = trid1;
            SqlCommand command = new SqlCommand("Select SecretaryNameSurname from Tbl_Secretary where SecretaryTC=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblnamesurname.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Transfer banches to combobox
            SqlCommand command2 = new SqlCommand("Select BranchName from Tbl_Branches", bgl.baglanti());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbranch.Items.Add(dr2[0]);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand commandsave = new SqlCommand("Insert into Tbl_Appointments (Appointmentdate,Appointmenttime,Appointmentbranch,Appointmentdoctor,Appointmentstate,Patienttridnumber) values (@a1,@a2,@a3,@a4,@a5,@a6 )", bgl.baglanti());
            commandsave.Parameters.AddWithValue("@a1", mskdate.Text);
            commandsave.Parameters.AddWithValue("@a2", mskhour.Text);
            commandsave.Parameters.AddWithValue("@a3", cmbbranch.Text);
            commandsave.Parameters.AddWithValue("@a4", cmbdoctor.Text);
            commandsave.Parameters.AddWithValue("@a5", chckstatus.Checked);
            commandsave.Parameters.AddWithValue("@a6", msktrid.Text);
            commandsave.ExecuteNonQuery();
            bgl.baglanti().Close();
            writingdatagrid();
            MessageBox.Show("Appointment is created", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbbranch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbdoctor.Items.Clear();

            SqlCommand command3 = new SqlCommand("Select DoctorName,DoctorSurname from Tbl_Doctors where DoctorBranch=@p1", bgl.baglanti());
            command3.Parameters.AddWithValue("@p1", cmbbranch.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            SqlCommand command4 = new SqlCommand("Insert into Tbl_Announcements (Announcement) values (@a1)", bgl.baglanti());
            command4.Parameters.AddWithValue("@a1", rchcreateanouncements.Text);
            command4.ExecuteNonQuery();
            bgl.baglanti().Close();
            writingdatagrid();
            MessageBox.Show("Announcement is created", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btndoctorpanel_Click(object sender, EventArgs e)
        {
            frmDoctorPanel fr = new frmDoctorPanel();
            fr.Show();
            
        }

        private void btnbranchpanel_Click(object sender, EventArgs e)
        {
            frmBranches fr = new frmBranches();
            fr.Show();
            
        }

        private void btnappointmentpanel_Click(object sender, EventArgs e)
        {
            frmappointmentlist fr = new frmappointmentlist();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmanouncements fr = new frmanouncements();
            fr.Show();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Appointments set Appointmentdate=@p1,Appointmenttime=@p2,Appointmentbranch=@p3,Appointmentdoctor=@p4,Appointmentstate=@p5 where Patienttridnumber=@p6", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", mskdate.Text);
            command.Parameters.AddWithValue("@p2", mskhour.Text);
            command.Parameters.AddWithValue("@p3", cmbbranch.Text);
            command.Parameters.AddWithValue("@p4", cmbdoctor.Text);
            command.Parameters.AddWithValue("@p5", chckstatus.Checked);
            command.Parameters.AddWithValue("@p6", msktrid.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            writingdatagrid();
            MessageBox.Show("Appointment is updated", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView3.SelectedCells[0].RowIndex;
            mskdate.Text = dataGridView3.Rows[selected].Cells[1].Value.ToString();
            mskhour.Text = dataGridView3.Rows[selected].Cells[2].Value.ToString();
            cmbbranch.Text = dataGridView3.Rows[selected].Cells[3].Value.ToString();
            cmbdoctor.Text = dataGridView3.Rows[selected].Cells[4].Value.ToString();
            msktrid.Text = dataGridView3.Rows[selected].Cells[6].Value.ToString();

        }
    }
} 

