using BestGrill.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGrill.DB
{
    class UserProvider : Provider
    {
        private static UserProvider instance;
        private UserProvider() { }
        public static UserProvider Instance
        {
            get { if (instance == null) instance = new UserProvider(); instance.Table = "category"; return UserProvider.instance; }
            private set { UserProvider.instance = value; }
        }

        public bool checkUser(string username, string password)
        {
            string query = "SELECT * FROM user WHERE username = '" + username + "' AND password = '" + password + "'";
            var result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0) return true;
            return false;
        }
    }
}
