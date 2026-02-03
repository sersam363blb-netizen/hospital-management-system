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
    public partial class frm_DoctorDetails : Form
    {
        public frm_DoctorDetails()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl =new sqlbaglantisi();
        
        public string doctortrid;
        

        private void frm_DoctorDetails_Load(object sender, EventArgs e)
        {
            lblTC.Text = doctortrid;
            

            // Doctor Name Surname
            SqlCommand command = new SqlCommand("Select DoctorName,DoctorSurname from Tbl_Doctors where DoctorTC=@p1", bgl.baglanti());
            command.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblnamesurname.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Appointments List to datagrid
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments where Appointmentdoctor=@a1 and Appointmentstate=1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@a1", lblnamesurname.Text);
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            frmDoctorEditInfo frm = new frmDoctorEditInfo();
            frm.tcno = lblTC.Text;
            frm.Show();
        }

        private void btnanouncement_Click(object sender, EventArgs e)
        {
            frmanouncements frmm= new frmanouncements();
            frmm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            rchproblemdetail.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();


        }
    }
}
