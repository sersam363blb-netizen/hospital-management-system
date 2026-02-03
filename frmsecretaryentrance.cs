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
    public partial class frmsecretaryentrance : Form
    {
        public frmsecretaryentrance()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_Secretary where SecretaryTC=@p1 and SecretaryPassword=@p2", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", msktrid.Text);
            command.Parameters.AddWithValue("@p2", txtpassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                frmsecretarydetails fr = new frmsecretarydetails();
                fr.trid1= msktrid.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid TR ID or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }

        private void frmsecretaryentrance_Load(object sender, EventArgs e)
        {

        }
    }
}
