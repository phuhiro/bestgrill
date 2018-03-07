
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGrill.Model
{
    public class User
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public User(string username,string password)
        {
            this.username = username;
            this.password = password;
        }

        public User(DataRow row)
        {
            this.username = row["username"].ToString();
            this.password = row["password"].ToString();
        }

    }
}
