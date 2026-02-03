using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hospital_Project
{
    public partial class Frm_PatientEntrance : Form
    {
        public Frm_PatientEntrance()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatienceSignUp signup = new FrmPatienceSignUp();
            signup.Show();
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Patients Where PatientTC=@p1 and PatientPassword=@p2",bgl.baglanti() );
            komut.Parameters.AddWithValue("@p1", msktrid.Text);
            komut.Parameters.AddWithValue("@p2", txtpassword.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmPatientDetails fr = new FrmPatientDetails();
                fr.trid = msktrid.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong TR ID or wrong password");
            }
        }
    }
}
