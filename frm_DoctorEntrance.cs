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
    public partial class frm_DoctorEntrance : Form
    {
        public frm_DoctorEntrance()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        

        private void btnEnter_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_Doctors where DoctorTC=@p1 and DoctorPassword=@p2", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", msktrid.Text);
            command.Parameters.AddWithValue("@p2", txtpassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                frm_DoctorDetails fr = new frm_DoctorDetails();
                fr.doctortrid = msktrid.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid TR ID or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
