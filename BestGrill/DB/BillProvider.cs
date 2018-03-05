using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGrill.DB
{
    class BillProvider : Provider
    {
        private static BillProvider instance;
        private BillProvider() { }
        public static BillProvider Instance
        {
            get { if (instance == null) instance = new BillProvider(); instance.Table = "category"; return BillProvider.instance; }
            private set { BillProvider.instance = value; }
        }        

        public DataTable LoadBillByTableId(int tableId)
        {
            DataTable data = new DataTable();
            string query = "SELECT * FROM bill WHERE table_id = " + tableId + " AND status = 0";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public Int64 CreateBill(int tableId)
        {
            Int64 id = 0;
            string query = "INSERT INTO bill(table_id) VALUES(" + tableId + "); SELECT LAST_INSERT_ID() as id";
            id = (Int64) DataProvider.Instance.ExecuteNonQuery(query);
            return id;
        }

        public Int64 PayBill(Int64 billId,float subtotal,float vat,float discount)
        {
            Int64 id = 0;
            float total = subtotal + subtotal * vat / 100 - subtotal * discount / 100;
            string query = "UPDATE bill SET status = 1, subtotal = "+subtotal +", discount = "+ discount + " , total = "+ total + 
                " WHERE id = " + billId;
            id = (Int64)DataProvider.Instance.ExecuteNonQuery(query);
            return id;
        }
    }
}
