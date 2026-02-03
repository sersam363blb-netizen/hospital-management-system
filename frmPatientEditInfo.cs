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
    public partial class frmPatientEditInfo : Form
    {
        public frmPatientEditInfo()
        {
            InitializeComponent();
        }
        
        public string trid1;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmPatientEditInfo_Load(object sender, EventArgs e)
        {
            msktrid.Text = trid1;
            SqlCommand komut = new SqlCommand("Select * from Tbl_Patients where PatientTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktrid.Text);
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                txtName.Text = dr1[1].ToString();
                txtsurname.Text = dr1[2].ToString();
                mskphone.Text = dr1[4].ToString();
                cmbgender.Text = dr1[5].ToString();
                txtpassword.Text = dr1[6].ToString();
            }
            bgl.baglanti().Close();
        }
        


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Patients set PatientName=@p2, PatientSurname=@p3, PatientPhone=@p4, PatientGender=@p5, PatientPassword=@p6 where PatientTC=@p7",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p2", txtName.Text);
            komut2.Parameters.AddWithValue("@p3", txtsurname.Text);
            komut2.Parameters.AddWithValue("@p4", mskphone.Text);
            komut2.Parameters.AddWithValue("@p5", cmbgender.Text);
            komut2.Parameters.AddWithValue("@p6", txtpassword.Text);
            komut2.Parameters.AddWithValue("@p7", msktrid.Text );
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Your İnformations Updated","İnfo",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
