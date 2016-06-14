using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Enrollment.Classes;

namespace Enrollment.Models
{
    public class Session
    {
        public String SessionID { get; private set; }
        public User CurrentUser { get; private set; }

        private static Session _CurrentSession;

        private Session() { }
        public Session(User user)
        {
            this.CurrentUser = user;
        }

        public bool Start()
        {
            this.SessionID = GenerateSessionID();
            _CurrentSession = this;

            //return ConnectionManager.ExecuteCommand("", this.CurrentUser.Username);
            return true;
        }

        private String GenerateSessionID()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            String AvailableStrings = "ABCDEFGHIJKLMNOPRQRSTUVWXYZ0123456789";
            String strOut = "S$";
            for (int i=0;i<15;i++)
            {
                strOut += AvailableStrings[rand.Next(AvailableStrings.Length)];
            }
            return strOut;
        }
        
        public static Session CurrentSession { get; private set; }
    }
}
