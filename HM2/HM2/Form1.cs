using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form2 user = new Form2();
            string us = "ibrahem";
            string pass = " Yazan";

            if (txtname.Text == us && txtpassword.Text == pass) 
            {
                user.Show();
            
            }
            if (txtname.Text == pass && txtpassword.Text == us ) 
            {
                user.Hide();
            
            
            
            }
            else 
            {
                MessageBox.Show("wrong password", "Error");
            
            }

            
        }
    }
}
