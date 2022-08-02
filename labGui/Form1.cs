using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace labGui
{
    public partial class Form1 : Form
    {
        public Form1(string username)
        {
            InitializeComponent();
            DisplayName.Text = DisplayName.Text + " "+ username;

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
 /* regex is not completely working. Will be fixed soon with its limitations  */
           /* Regex re = new Regex(@"^[a-z]$");
            if (re.IsMatch(txt_name.Text))
            {
                MessageBox.Show("Not corect");
            }
            else
            {
                 MessageBox.Show("Not corect");
            }*/
            /*if (txt_name.Text.Length < 3)
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
            */
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
                isavailable = checkbox1.Checked,
                radiobtn = rdbtn1.Checked ? true:(rdbtn2.Checked ? true:false)

                

            };
            /*pr.save();
            MessageBox.Show("Qeury saved!");*/
            /*string name = $"Hello {textBox1.Text}";*/


            /*MessageBox.Show("Hello "+ name);*/

            string checkedItems = " ";
            foreach (var item in chkList.CheckedItems)
            {
                checkedItems += item.ToString();
              

            }
            MessageBox.Show(checkedItems);
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdbtn2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void DisplayName_Click(object sender, EventArgs e)
        {

        }
    }
}
