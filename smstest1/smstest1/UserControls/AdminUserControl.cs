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
    public partial class AdminUserControl : UserControl
    {
        
        public AdminUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControlInititalizer.userControlInit(new AdmitUserFrom_UC());
        }

        private void semesterBtn_Click(object sender, EventArgs e)
        {
            UserControlInititalizer.userControlInit(new CreateSemester_UC());
        }

        private void crsbtn_Click(object sender, EventArgs e)
        {
            UserControlInititalizer.userControlInit(new CreateCourse_UC());
        }
    }
}
