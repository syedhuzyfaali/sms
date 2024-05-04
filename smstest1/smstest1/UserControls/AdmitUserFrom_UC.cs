using smstest1.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smstest1
{
    public partial class AdmitUserFrom_UC : UserControl
    {
        string connectionString = "Data Source=DESKTOP-GPFBM2J\\SQLEXPRESS;Initial Catalog=smstest1_winforms;Integrated Security=True;";

        

        public AdmitUserFrom_UC()
        {
            InitializeComponent();
        }

        private void AdmitUserFrom_UC_Load(object sender, EventArgs e)
        {
            passmatcherror.Visible = false;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
          

        }

        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            bool anyerror = false;
            DateTime date = InputDOB.Value.Date;
            string tablename = InputRole.SelectedItem.ToString();
            string upass = InputPas.Text;
            string conpass = ConPas.Text;

            if (InputPas.Text != ConPas.Text)
            {
                passmatcherror.Visible = true;
                anyerror = true;

            }
            string email = InputEmail.Text;
            int role = 10;

            if (tablename == "Administration")
            {
                role = 10;
            }
            else if (tablename == "Instructor")
            {
                role = 11;
            }
            else if (tablename == "Student")
            {
                role = 12;
            }
            else
            {
                anyerror = true;
            }
            string name = InputFname.Text;
            string gender = RbtnMale.Checked ? gender = "Male" : gender = "Female";
            int phone = int.Parse(InputPhNum.Text);
            string address = InputAdres.Text;

            SqlFunctions sqlFunctions = new SqlFunctions(connectionString);

            if (!anyerror)
            {
                bool retrunvale = sqlFunctions.AddUser(tablename, upass, conpass, email, role, name, date, gender, phone, address);
                if (retrunvale)
                {
                    returnval.Text = "Success";
                }
                else
                {
                    returnval.Text = "False";
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
