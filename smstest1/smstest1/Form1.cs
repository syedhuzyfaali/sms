using smstest1.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smstest1
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }   
        }

        public Panel Mainpanel
        {
            get { return panel; }
            set { panel = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;

            UserControlInititalizer.userControlInit(new LoginForm_UC());
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           

            
        }

       
    }
}
