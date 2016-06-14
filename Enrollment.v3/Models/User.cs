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
            Session s = null;
            
            using(MySqlDataReader reader = ConnectionManager.ExecuteQuery(Queries.Data["USER_LOGIN_DATA"], this.Username))
            {
                if (reader.Read())
                {
                    if (reader["Password"].ToString() == SecurityUtils.MD5(this.Password))
                    {
                        RadMessageBox.Show(String.Format("You are now logged in as [{0}].", this.Username), "Welcome!", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Info);
                        s = new Session(this);
                    }
                    else
                    {
                        RadMessageBox.Show("Incorrect Password!", "Error!", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Error);
                    }
                }
                else
                {
                    RadMessageBox.Show("User does not exist!", "Error!", System.Windows.Forms.MessageBoxButtons.OK, RadMessageIcon.Error);
                }
            }

            if(s!=null)
            {
                s.Start();
            }
            return s;
        }

        public bool Save()
        {
            return ConnectionManager.ExecuteCommand("");
        }

        public bool Update()
        {
            return ConnectionManager.ExecuteCommand("");
        }
    }

}
