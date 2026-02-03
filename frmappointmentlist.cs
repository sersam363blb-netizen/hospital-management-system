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
    public partial class frmappointmentlist : Form
    {
        public frmappointmentlist()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void frmappointmentlist_Load(object sender, EventArgs e)
        {
          DataTable dt= new DataTable();
          SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments", bgl.baglanti());
          da.Fill(dt);
          dataGridView1.DataSource = dt;
          
        }

        
    }
}
