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
    public partial class Items_User_Control1 : UserControl
    {
        private static Items_User_Control1 _instance;
        public static Items_User_Control1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Items_User_Control1();
                }
                return _instance;
            }
        }
        public Items_User_Control1()
        {
            InitializeComponent();
        }

        private void Items_User_Control1_Load(object sender, EventArgs e)
        {

        }
    }
}
