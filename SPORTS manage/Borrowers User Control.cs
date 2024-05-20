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
    public partial class Borrowers_User_Control : UserControl
    {
        private static Borrowers_User_Control _instance;
        public static Borrowers_User_Control Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Borrowers_User_Control();
                }
                return _instance;
            }
        }
        public Borrowers_User_Control()
        {
            InitializeComponent();
        }

        private void Borrowers_User_Control_Load(object sender, EventArgs e)
        {

        }
    }
}
