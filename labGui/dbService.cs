using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // this will help us import the sql connection Class 
namespace labGui
{
    public partial class dbService : Form
    {
        public void DBService()
        {

            try
            {
                string constr = @"Data Source=SIMON\SQLEXPRESS ; Initial Catalog =LabFinal; Integrated Security= True";
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                MessageBox.Show("Database Connected!");
                string Query = "insert into person values ('Simon Asaye Asnake ',' Addis Ababa',176,21,68,100,'2001-07-27' ) ";
                SqlCommand cmd = new SqlCommand(Query, con);
                var result = cmd.ExecuteNonQuery();
                //MessageBox.Show(Parse(result.ToString));
            }
            catch
            {
                MessageBox.Show("Database not Connected!");
            }
        }
        public dbService()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = @"Data Source=SIMON\SQLEXPRESS ; Initial Catalog =LabFinal; Integrated Security= True";
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                MessageBox.Show("Database Connected!");
                string Query = "insert into person values ('Simon Asaye Asnake ',' Addis Ababa',176,21,68,100,'2001-07-27' ) ";
                SqlCommand cmd = new SqlCommand(Query, con);
                var result = cmd.ExecuteNonQuery();
                //MessageBox.Show(Parse(result.ToString));
            }
            catch
            {
                MessageBox.Show("Unable To Connect!!");
            }
            
        }
    }
}
