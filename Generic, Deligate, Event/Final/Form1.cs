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

namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = "data source=.; database= LabFinal; integrated security=SSPI";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from Person",con);
            con.Open();
            SqlDataReader sdr= cmd.ExecuteReader();
            dataGridView1.DataSource = sdr;
            dataGridView1.DataMember = "Person";
            con.Close();

        }
    }
}
