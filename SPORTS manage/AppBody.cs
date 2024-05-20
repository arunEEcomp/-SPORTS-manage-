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
    public partial class AppBody : Form
    {
        public AppBody()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Department_User_Control1.Instance))
            {
                panel3.Controls.Add(Department_User_Control1.Instance);
                Department_User_Control1.Instance.Dock = DockStyle.Fill;
                Department_User_Control1.Instance.BringToFront();
            }
            else
            {
                Department_User_Control1.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Items_User_Control1.Instance))
            {
                panel3.Controls.Add(Items_User_Control1.Instance);
                Items_User_Control1.Instance.Dock = DockStyle.Fill;
                Items_User_Control1.Instance.BringToFront();
            }
            else
            {
                Items_User_Control1.Instance.BringToFront();
            }
        }

        private void AppBody_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Borrowers_User_Control.Instance))
            {
                panel3.Controls.Add(Borrowers_User_Control.Instance);
                Borrowers_User_Control.Instance.Dock = DockStyle.Fill;
                Borrowers_User_Control.Instance.BringToFront();
            }
            else
            {
                Borrowers_User_Control.Instance.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Transaction_User_Control1.Instance))
            {
                panel3.Controls.Add(Transaction_User_Control1.Instance);
                Transaction_User_Control1.Instance.Dock = DockStyle.Fill;
                Transaction_User_Control1.Instance.BringToFront();
            }
            else
            {
                Transaction_User_Control1.Instance.BringToFront();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(About_User_Control1.Instance))
            {
                panel3.Controls.Add(About_User_Control1.Instance);
                About_User_Control1.Instance.Dock = DockStyle.Fill;
                About_User_Control1.Instance.BringToFront();
            }
            else
            {
                About_User_Control1.Instance.BringToFront();
            }
        }
    }
}
