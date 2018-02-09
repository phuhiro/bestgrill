using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGrill.DB
{
    class Provider : IProvider
    {
        private string table;

        public string Table
        {
            get { return table; }
            set { table = value; }
        }


        public DataTable getAll()
        {
            string query = "SELECT * FROM " + this.table;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public DataTable findById(int id)
        {
            string query = "SELECT * FROM " + this.table + " WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
