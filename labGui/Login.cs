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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            password.PasswordChar = '*';

            //this will hash the inputs from user to asteriks 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string psd = password.Text;
            //validation will happen here 
            if(user == "admin" && psd =="admin")
            {
                string username = user;
                Form form1 = new Form1(username);
                form1.Show();
                this.Hide();
                //hide the login form
                //the program isn't exited when it is closed. So we have to manually stop it.

            }
            else
            {
                MessageBox.Show("Incorrect input");
            }

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
