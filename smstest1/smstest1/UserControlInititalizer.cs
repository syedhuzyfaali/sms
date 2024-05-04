using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smstest1
{
     static internal class UserControlInititalizer
    {
        public static void userControlInit(UserControl userControl)
        {
            Form1.Instance.Mainpanel.Controls.Clear();
            Form1.Instance.Mainpanel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
            userControl.BringToFront();
        }
    }
}
