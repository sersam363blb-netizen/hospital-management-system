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
    public partial class frmBranches : Form
    {
        public frmBranches()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmBranches_Load(object sender, EventArgs e)
        {
            //Tranfer branches to datagrid
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branches", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            
            //Transfer banches to combobox
            SqlCommand command2 = new SqlCommand("Select BranchName from Tbl_Branches", bgl.baglanti());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbranch.Items.Add(dr2[0]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand commandsave = new SqlCommand("Insert into Tbl_Branches (BranchName) values (@b1)", bgl.baglanti());
            commandsave.Parameters.AddWithValue("@b1", cmbbranch.Text);
            commandsave.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branch Added","Information",MessageBoxButtons.OK);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand commandsave = new SqlCommand("Delete from Tbl_Branches where BranchName=@b1", bgl.baglanti());
            commandsave.Parameters.AddWithValue("@b1", cmbbranch.Text);
            commandsave.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branch Deleted","Information", MessageBoxButtons.OK);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand commandsave = new SqlCommand("Update Tbl_Branches set BranchName=@b1 where BranchID=@b2", bgl.baglanti());
            commandsave.Parameters.AddWithValue("@b1", cmbbranch.Text);
            commandsave.Parameters.AddWithValue("@b2", txtid.Text);
            commandsave.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branch Updated","Information", MessageBoxButtons.OK);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            cmbbranch.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            
        }
    }
}
