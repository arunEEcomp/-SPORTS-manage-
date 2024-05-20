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
    public partial class Transaction_User_Control1 : UserControl
    {
        private static Transaction_User_Control1 _instance;
        public static Transaction_User_Control1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Transaction_User_Control1();
                }
                return _instance;
            }
        }
        public Transaction_User_Control1()
        {
            InitializeComponent();
        }

        private void Transaction_User_Control1_Load(object sender, EventArgs e)
        {

        }
    }
}
