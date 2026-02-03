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
    public partial class FrmPatientDetails : Form
    {
        public FrmPatientDetails()
        {
            InitializeComponent();
        }
        public string trid;

        sqlbaglantisi bgl = new sqlbaglantisi();

        public void appointmenthistory() { 
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments where Patienttridnumber='" + trid + "'", bgl.baglanti());
        da.Fill(dt);
        dataGridView1.DataSource = dt;
            }

        private void FrmPatientDetails_Load(object sender, EventArgs e)
        {

            appointmenthistory();
            //Name Surname writing
            lblTC.Text = trid;
            SqlCommand komut = new SqlCommand("Select PatientName, PatientSurname from Tbl_Patients Where PatientTC= @p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblnamesurname.Text = dr[0] +" "+ dr[1];
            }
            bgl.baglanti().Close();

            // Branches Writing
            SqlCommand komut2 = new SqlCommand("Select BranchName from Tbl_Branches",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbranch.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
            
        }

        // Doctors Writing
        private void cmbbranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoctor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoctorName, DoctorSurname from Tbl_Doctors where DoctorBranch=@b1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@b1", cmbbranch.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbdoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments where Appointmentbranch='"+ cmbbranch+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            appointmenthistory();
        }
        
        
        private void lnkeditinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPatientEditInfo fr = new frmPatientEditInfo();
            fr.trid1 = lblTC.Text; 
            fr.Show();
        }

        private void btnappointment_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Appointments (AppointmentBranch,AppointmentDoctor,PatientProblem,Patienttridnumber) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            command.Parameters.AddWithValue("@r1", cmbbranch.Text);
            command.Parameters.AddWithValue("@r2", cmbdoctor.Text);
            command.Parameters.AddWithValue("@r3", rchproblems.Text);
            command.Parameters.AddWithValue("@r4", lblTC.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Your Appointment Created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
