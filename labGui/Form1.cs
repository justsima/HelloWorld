using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
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
            Products p = new Products()
            {
                number = int.Parse(txt_number.Text),
                date = DateTime.Parse(txt_date.Text),
                inventory = int.Parse(txt_inventory.Text),
                name = (txt_name.Text),
                count = int.Parse(txt_count.Text),
                price = int.Parse(txt_price.Text),

            };
            Regex re = new Regex(@"^[a-z]{3}$");
            if (re.IsMatch(txt_name.Text))
            {
               
            }
            else
            {
                 MessageBox.Show("Not coreect");
            }
            if (txt_name.Text.Length < 3)
            {
                MessageBox.Show("Digit must be less than 3");
            }
            if (String.IsNullOrEmpty(txt_name.Text))
            {
                ep1.SetError(txt_name, "name is required");
               // MessageBox.Show("Name is required");
            }

                try
                {
                    int price = int.Parse(txt_price.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("Invalid price");
                }
            
            p.save();
            // to save all data from the form to the view
            dt1.DataSource = null;
            dt1.DataSource = Products.GetAllProducts();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
