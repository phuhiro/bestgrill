using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGrill.Model
{
    class Category
    {
        private int iD;
        public Category(int id, string name)
        {
            this.iD = id;
            this.name = name;
        }
        public Category(DataRow row)
        {
            this.iD = (int)row["id"];
            this.name = row["name"].ToString();
        }
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
