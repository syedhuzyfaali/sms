using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using smstest1.UserControls;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Xml.Linq;

namespace smstest1
{
    internal class SqlFunctions
    {
        //string connectionString = "Data Source=DESKTOP-GPFBM2J\\SQLEXPRESS;Initial Catalog=smstest1_winforms;Integrated Security=True;";
        private string connectionString;
       
        public SqlFunctions(string _connectionString)
        {
            this.connectionString = _connectionString;
        }
       

        public void LoginToAccount(int userid, string userpassword)
        {
            string queryTemp = "select role_name from Roles as R\r\ninner join\r\nUsers as U\r\non \r\nR.role_id = U.role_id\r\nwhere users_id = "+userid+" and user_pass = '"+userpassword+"' ";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(queryTemp, con))
                {
                    con.Open();
                    var returnValue = (string)cmd.ExecuteScalar();
                    openDashBoard(returnValue);
                    con.Close();
                }
            }

        }

        private void openDashBoard(string role)
        {
            switch(role)
            {
                case "Admin":
                    MessageBox.Show("Admin");
                    UserControlInititalizer.userControlInit(new AdminUserControl());
                    break;
                case "Instructor":
                    MessageBox.Show("Instructor");
                    break;
                case "Student":
                    MessageBox.Show("Student");
                    break;
                default:
                    MessageBox.Show("NotFound");
                    break;
            }
        }

       


        public bool AddUser(string tbname, string upass, string urpass, string email, int role_id, string name, DateTime date, string gender, int phone, string address)
        {
            int returnvalue;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ADD_USERS_PROC", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@table_name", tbname);
                    cmd.Parameters.AddWithValue("@user_pass", upass);
                    cmd.Parameters.AddWithValue("@user_rec_pass", urpass);
                    cmd.Parameters.AddWithValue("@user_email", email);
                    cmd.Parameters.AddWithValue("@role_id", role_id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@dob", date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address.ToString());

                    returnvalue = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            if(returnvalue != 2)
            {
                return false;
            }
            else
            {
                return true;
            }

        
            
        }
        public bool addSemester(int year, string term, DateTime sDate, DateTime eDate)
        {
            string query = "insert into Semester values(@year, @term, @sDate, @eDate)";
            int returnvalue;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@term", term);
                    cmd.Parameters.AddWithValue("@sDate", sDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@eDate", eDate.ToString("yyyy-MM-dd"));
                    returnvalue = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            if (returnvalue != 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool addCourse(string name, string desc, decimal crdhrs, int fee)
        {
            string query = "insert into Course values(@name, @desc, @crdhrs, @fee)";
            int returnvalue;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@desc", desc);
                    cmd.Parameters.AddWithValue("@crdhrs", crdhrs);
                    cmd.Parameters.AddWithValue("@fee", fee);
                    returnvalue = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            if (returnvalue != 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
