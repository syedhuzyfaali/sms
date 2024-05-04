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
    public partial class CreateSemester_UC : UserControl
    {
        string connectionString = "Data Source=DESKTOP-GPFBM2J\\SQLEXPRESS;Initial Catalog=smstest1_winforms;Integrated Security=True;";

        public CreateSemester_UC()
        {
            InitializeComponent();
        }

        private void CreateSemester_UC_Load(object sender, EventArgs e)
        {
            for (int i = int.Parse(DateTime.Now.ToString("yy")) ;i <= 99; i++  )
            cboxSemesterYear.Items.Add(i.ToString());
        }

        private void addSemBtn_Click(object sender, EventArgs e)
        {
            int year = int.Parse(cboxSemesterYear.SelectedItem.ToString().Insert(0,"20"));
            string term = cboxSemesterTerm.SelectedItem.ToString();
            DateTime startdate = semesterStart.Value.Date;
            DateTime enddate = semesterEnd.Value.Date;

            SqlFunctions sqlFunctions = new SqlFunctions(connectionString);
           bool returnvalue =  sqlFunctions.addSemester(year, term, startdate, enddate);
            if (returnvalue)
            {
                returnval.Text = "Success";
            }
            else
            {
                returnval.Text = "Falied";
            }

        }
    }
}
