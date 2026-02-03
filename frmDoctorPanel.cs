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
    public partial class frmDoctorPanel : Form
    {
        public frmDoctorPanel()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public void doctorstodatagrid()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Doctors", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglanti().Close();
        }
        private void frmDoctorPanel_Load(object sender, EventArgs e)
        {
            doctorstodatagrid();
       
            // Branches to combobox
            SqlCommand komut2 = new SqlCommand("Select BranchName from Tbl_Branches", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbranches.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command= new SqlCommand("delete from Tbl_Doctors where DoctorTC=@d1", bgl.baglanti());
            command.Parameters.AddWithValue("@d1", msktrid.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doctorstodatagrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command= new SqlCommand("insert into Tbl_Doctors (DoctorName,DoctorSurname,DoctorBranch,DoctorTC,DoctorPassword) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            command.Parameters.AddWithValue("@d1", txtname.Text);
            command.Parameters.AddWithValue("@d2", txtsurname.Text);
            command.Parameters.AddWithValue("@d3", cmbbranches.Text);
            command.Parameters.AddWithValue("@d4", msktrid.Text);
            command.Parameters.AddWithValue("@d5", txtpassword.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("New doctor added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doctorstodatagrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command= new SqlCommand("update Tbl_Doctors set DoctorName=@d1,DoctorSurname=@d2,DoctorBranch=@d3,DoctorPassword=@d5 where DoctorTC=@d4", bgl.baglanti());
            command.Parameters.AddWithValue("@d1", txtname.Text);
            command.Parameters.AddWithValue("@d2", txtsurname.Text);
            command.Parameters.AddWithValue("@d3", cmbbranches.Text);
            command.Parameters.AddWithValue("@d4", msktrid.Text);
            command.Parameters.AddWithValue("@d5", txtpassword.Text);
            command.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doctor information updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            doctorstodatagrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtname.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtsurname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            cmbbranches.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            msktrid.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            txtpassword.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();

        }
    }
}
