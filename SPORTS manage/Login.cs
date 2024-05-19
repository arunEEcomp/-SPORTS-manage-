using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPORTS_manage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Uname = "Arun Kumar", Upass = "Amazon.in@123**", name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            // for login
            if(name.Equals(Uname) && pass.Equals(Upass) )
            {
                // for login
                MessageBox.Show("Log In Sucessful");
            }
            else
            {
                // for login
                MessageBox.Show("Log In Unsucessful");
            }
        }
    }
}
