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
    public partial class frmDoctorEditInfo : Form
    {
        public frmDoctorEditInfo()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tcno;
        private void frmDoctorEditInfo_Load(object sender, EventArgs e)
        {
            msktrid.Text= tcno;
            SqlCommand command = new SqlCommand("select * from Tbl_Doctors where DoctorTC=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", msktrid.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtsurname.Text = dr[2].ToString();
                comboBox1.Text = dr[3].ToString();
                txtpassword.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();

            // Branches to combobox
            SqlCommand command2 = new SqlCommand("Select BranchName from Tbl_Branches", bgl.baglanti());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
                            {
                comboBox1.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("update Tbl_Doctors set DoctorName=@p1, DoctorSurname=@p2, DoctorBranch=@p3, DoctorPassword=@p4 where DoctorTC=@p5", bgl.baglanti());
            command2.Parameters.AddWithValue("@p1", txtName.Text);
            command2.Parameters.AddWithValue("@p2", txtsurname.Text);
            command2.Parameters.AddWithValue("@p3", comboBox1.Text);
            command2.Parameters.AddWithValue("@p4", txtpassword.Text);
            command2.Parameters.AddWithValue("@p5", msktrid.Text);
            command2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Your İnformations Updated", "İnfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
