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
    public partial class Department_User_Control1 : UserControl
    {
        private static Department_User_Control1 _instance;
        public static Department_User_Control1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Department_User_Control1();
                }
                return _instance;
            }
        }
        public Department_User_Control1()
        {
            InitializeComponent();
        }

        private void Department_User_Control1_Load(object sender, EventArgs e)
        {

        }
    }
}
