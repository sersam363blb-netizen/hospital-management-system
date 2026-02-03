using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class FrmEntrances : Form
    {
        public FrmEntrances()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_PatientEntrance patient = new Frm_PatientEntrance();
            patient.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frm_DoctorEntrance doctor = new frm_DoctorEntrance();
            doctor.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmsecretaryentrance secretary = new frmsecretaryentrance();
            secretary.Show();
            this.Hide();
        }
    }
}
