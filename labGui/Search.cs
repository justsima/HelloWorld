using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labGui
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var products = Products.findone(txt_Search.Text);
            if (products == null)
            {
                MessageBox.Show("Not found!");

            }
            else
            {
                //label3.Text =products.name
                //dataGridView1.DataSource = Products.GetAllProducts();
                MessageBox.Show($"Product found! \n Name: {products.name}\n" +
                $"Detailed information on the Update Menu!");

            }            
        }
    }
}
