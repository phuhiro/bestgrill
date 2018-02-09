using BestGrill.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGrill.DB
{
    class TableProvider : Provider
    {
        private static TableProvider instance;
        private TableProvider() { }
        public static TableProvider Instance
        {
            get { if (instance == null) instance = new TableProvider(); instance.Table = "tables"; return TableProvider.instance; }
            private set { TableProvider.instance = value; }
        }

        public List<Table> loadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = this.getAll();
            foreach(DataRow row in data.Rows)
            {
                Table tmp = new Table(row);
                tableList.Add(tmp);
            }
            return tableList;
        }

        public int UpdateStatus(int tableId,int status )
        {
            int result = 0;
            string query = "UPDATE tables SET status = " + status + " WHERE id = " + tableId;
            DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
    }
}
