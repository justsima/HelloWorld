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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewProductToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {

        }

        private void displayNewPrductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Search search = new Search();
            search.MdiParent=this;
            search.Show();
        }

       
       /* private void button1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
        }
       */
 

        private void updateNewProductToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Dsiplay up = new Dsiplay();
            up.MdiParent = this;
            up.Show();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
