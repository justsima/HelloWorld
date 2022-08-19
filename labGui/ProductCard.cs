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
    public partial class ProductCard : UserControl
    {
        // Products p = new Products();
        //prop tab tab for the public
        //propfull tab tab for the private

        private int _MyNum;

        public int MyNum
        {
            get { return _MyNum; }
            set { _MyNum = value; lbl_Number.Text = value.ToString(); }
        }
        private string _MyDate;

        public string MyDate
        {
            get { return _MyDate; }
            set { _MyDate = value; lbl_Date.Text = value; }
        }
        private int _MyInvNum;

        public int MyInvNum
        {
            get { return _MyInvNum; }
            set { _MyInvNum = value; lbl_Inventory.Text = value.ToString(); }
        }

        private string _MyObjName;

        public string MyObjName
        {
            get { return _MyObjName; }
            set { _MyObjName = value; lbl_Object.Text = value; }
        }
        private int _MyCount;

        public int MyCount
        {
            get { return _MyCount; }
            set { _MyCount = value; lbl_Count.Text = value.ToString(); }
        }
        private double _MyPrice;

        public double MyPrice
        {
            get { return _MyPrice; }
            set { _MyPrice = value; ;lbl_Price.Text = value.ToString(); }
        }

        public ProductCard()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
