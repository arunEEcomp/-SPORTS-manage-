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
    public partial class About_User_Control1 : UserControl
    {
        private static About_User_Control1 _instance;
        public static About_User_Control1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new About_User_Control1();
                return _instance;
            }
            set { _instance = value; }
        }
        public About_User_Control1()
        {
            InitializeComponent();
        }

        private void About_User_Control1_Load(object sender, EventArgs e)
        {

        }
    }
}
