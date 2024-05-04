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
    public partial class CreateCourse_UC : UserControl
    {
        string connectionString = "Data Source=DESKTOP-GPFBM2J\\SQLEXPRESS;Initial Catalog=smstest1_winforms;Integrated Security=True;";

        public CreateCourse_UC()
        {
            InitializeComponent();
        }

        private void CreateCourse_UC_Load(object sender, EventArgs e)
        {
            
        }

        private void addCrsBtn_Click(object sender, EventArgs e)
        {
            string courseName = InputCoursename.Text;
            string courseDesc = InputDesc.Text;
            decimal crdhrs = courseCrdHrs.Value;
            int coursefee = int.Parse(courseFee.Text);

            SqlFunctions sqlFunctions = new SqlFunctions(connectionString);
            bool returnvalue = sqlFunctions.addCourse(courseName, courseDesc, crdhrs, coursefee);

            if (returnvalue)
            {
                returnval.Text = "Success";
            }
            else
            {
                returnval.Text = "Failed";
            }
        }
    }
}
