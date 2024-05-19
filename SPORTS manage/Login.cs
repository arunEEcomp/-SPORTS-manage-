using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SPORTS_manage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"Z:\\Sports\\SPORTS manage\\Sports Database.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private String getUserName()
        {
            // fetch the data from database
            conn.Open ();
            String syntax = "SELECT Value from loginTable where Property = 'UserName' ";
            cmd = new SqlCommand (syntax, conn);
            dr = cmd.ExecuteReader ();
            dr.Read ();
            String temp = dr[0].ToString();
            conn.Close();
            return temp;
        }

        private String getPassword()
        {
            // fetch the data from database
            conn.Open();
            String syntax = "SELECT Value from loginTable where Property = 'Password' ";
            cmd = new SqlCommand(syntax, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            conn.Close();
            return temp;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Uname = getUserName(), Upass = getPassword(), name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            // for login
            if(name.Equals(Uname) && pass.Equals(Upass) )
            {
                // for login
                AppBody obj = new AppBody();
                this.Hide();
                obj.Show();
            }
            else
            {
                // for login
                MessageBox.Show("Log In Unsucessful");
            }
        }
    }
}
