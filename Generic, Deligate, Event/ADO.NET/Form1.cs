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


namespace ADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = "data source =SIMON\\SQLEXPRESS;database=LabFinal; integrated security=true";
            using (SqlConnection con= new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("spGetPerson", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds= new DataSet();
                da.Fill(ds);

            }
            List<int> integerlist = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7,
            };
            var query = from obj in integerlist
                        where obj > 5
                        select obj;
            foreach (var item in query)
            {
                Console.WriteLine(item +" ");
            }

        }
    }
}
