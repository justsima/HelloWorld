﻿using System;
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
    public partial class Dsiplay : Form
    {
        public Dsiplay()
        {
            InitializeComponent();
        }
       

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {
           /*// pnlContainer.Controls.Clear();
            foreach (var item in Products.GetAllProducts())
            {
                ProductCard pc = new ProductCard();
                pc.MyNum = item.number;
                pc.MyDate = item.date;
                pc.MyInvNum = item.inventory;
                pc.MyObjName = item.name;
                pc.MyCount = item.count;
                pc.MyPrice = item.price;
                pnlContainer.Controls.Add(pc);
            }*/
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {
            foreach (var item in Products.GetAllProducts())
            {
                ProductCard pc = new ProductCard();
                pc.MyNum = item.number;
                pc.MyDate = item.date;
                pc.MyInvNum = item.inventory;
                pc.MyObjName = item.name;
                pc.MyCount = item.count;
                pc.MyPrice = item.price;
                pc.Click += (Object o, EventArgs e2) =>
                {
                    DetailsPage d = new DetailsPage(item.number, item.date, item.inventory, item.name, item.count, item.price);
                    d.Show();
                };
                pnlContainer.Controls.Add(pc);
            }
        }
    }
}
