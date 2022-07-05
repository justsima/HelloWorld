using System;
using System.Windows.Forms;

namespace labGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products pr = new Products
            {
                number = int.Parse(txt_number.Text),
                date = DateTime.Parse(txt_date.Text),
                inventory = int.Parse(txt_inventory.Text),
                name= (txt_name.Text),
                count = int.Parse(txt_count.Text),
                price = int.Parse(txt_price.Text),

            };
            pr.save();
            MessageBox.Show("Qeury saved!");
            /*string name = $"Hello {textBox1.Text}";*/

            /*MessageBox.Show("Hello "+ name);*/
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
