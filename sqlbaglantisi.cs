using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Project
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-19VKL11;Initial Catalog=Hospital_Project;Integrated Security=True; Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}
