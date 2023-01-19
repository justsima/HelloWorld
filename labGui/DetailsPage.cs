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
    public partial class DetailsPage : Form
    {
        public DetailsPage(int num, string date, int invnum, string objname, int count, double price)
        {
            InitializeComponent();
            label2.Text = "Num: " + num.ToString();
            label4.Text = "Date: " + date;
            label6.Text = "Inv num: " + invnum.ToString();
            label8.Text = "Obj name: " + objname;
            label10.Text = "Count: " + count.ToString();
            label12.Text = "Price: " + price.ToString();
        }
    }
}
