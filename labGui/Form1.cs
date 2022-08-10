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

        private void button1_Click(object sender, EventArgs e)
        {
            errorPro1.Clear();
            Regex r = new Regex(@"^([^0-9]*)$");
            if (string.IsNullOrEmpty(txt_number.Text))
            {
                errorPro1.SetError(txt_number, "Number is required");
            }
            else if (string.IsNullOrEmpty(txt_inventory.Text))
            {
                errorPro1.SetError(txt_inventory, "Inventory Number is required");
            }
            else if (string.IsNullOrEmpty(txt_name.Text))
            {
                errorPro1.SetError(txt_name, "Object name is required");
            }
            else if (string.IsNullOrEmpty(txt_count.Text))
            {
                errorPro1.SetError(txt_count, "Count is required");
            }
            else if (string.IsNullOrEmpty(txt_price.Text))
            {
                errorPro1.SetError(txt_price, "Price is required");
            }
            else if (!r.IsMatch(txt_name.Text))
            {
                errorPro1.SetError(txt_name, "String should not have numbers.");
            }
            else
            {
                try
                {
                    Products p = new Products()
                    {
                        number = int.Parse(txt_number.Text),
                        date = txt_date.Text,
                        inventory = int.Parse(txt_inventory.Text),
                        name = (txt_name.Text),
                        count = int.Parse(txt_count.Text),
                        price = int.Parse(txt_price.Text),


                    };
                    p.save();
                    // to save all data from the form to the view
                    dt1.DataSource = null;
                    dt1.DataSource = Products.GetAllProducts();

                }
                catch (Exception)
                {
                    MessageBox.Show("Type mismatch");
                };
                string checkedItems = " ";
                foreach (var item in chkList.CheckedItems)
                {
                    checkedItems += item.ToString();
                }
                MessageBox.Show(checkedItems);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
    