using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGrill.Model
{
    class Table
    {
        public Table(int id, string name, bool status)
        {
            this.ID = id;
            this.name = name;
            this.status = status;
        }
        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.name = row["name"].ToString();
            this.status = (bool)row["status"];
        }
        private int iD;

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
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
