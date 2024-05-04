using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smstest1.UserControls
{
    public partial class LoginForm_UC : UserControl
    {
        public LoginForm_UC()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-GPFBM2J\\SQLEXPRESS;Initial Catalog=smstest1_winforms;Integrated Security=True;";
            SqlFunctions sqlfunctions = new SqlFunctions(connectionString);
            sqlfunctions.LoginToAccount(int.Parse(txtuserid.Text), txtpassword.Text);
        }
    }
}
