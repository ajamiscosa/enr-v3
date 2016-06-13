using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Telerik.WinControls;
using Telerik.WinControls.UI;

using Enrollment.Classes;

namespace Enrollment.Models
{
    public class User
    {
        public String UserID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String AccessLevel { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String DisplayName { get; set; }
        public String Address { get; set; }
        public String EmailAddress { get; set; }
        public String ContactNo { get; set; }
        public String LoginStatus { get; set; }
        public String AccountStatus { get; set; }

        public User()
        {
        }

        public User(String username, String password)
        {
            this.Username = username;
            this.Password = password;
        }

        public Session Login()
        {
            Session s = new Session(this);
            
            using(MySqlDataReader reader = ConnectionManager.ExecuteQuery(Queries.Data["USER_LOGIN_DATA"], this.Username))
            {
                if(reader.Read())
                {
                    if(reader["Password"].ToString()==SecurityUtils.MD5(this.Password))
                    {

                    }
                }
                else
                {
                    RadMessageBox.Show("User does not exist", "Error!", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            }


            return s;
        }
    }

}
