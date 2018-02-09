using BestGrill.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGrill.DB
{
    class BillItemProvider : Provider
    {
        private static BillItemProvider instance;
        private BillItemProvider() { }
        public static BillItemProvider Instance
        {
            get { if (instance == null) instance = new BillItemProvider(); instance.Table = "category"; return BillItemProvider.instance; }
            private set { BillItemProvider.instance = value; }
        }

        public List<BillItem> loadBillItemById(Int64 billId)
        {
            List<BillItem> listBillItem = new List<BillItem>();
            string query = "SELECT bill_item.id,dish.name,dish.price,bill_item.quantity FROM bill_item "+
                            "INNER JOIN bill ON bill_item.bill_id = bill.id "+
                            "INNER JOIN dish ON dish.id = bill_item.dish_id "+
                            "WHERE bill.status = 0 AND bill_item.bill_id = " + billId;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                listBillItem.Add(new BillItem(row));
            }
            return listBillItem;
        }

        public bool dishExist(int dishId, Int64 billId)
        {
            string query = "SELECT * FROM bill_item WHERE dish_id = " + dishId + " AND bill_id = " + billId;
            var data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;

        }
        public int AddDishToBill(int dishId, int quantity, Int64 billId)
        {
            int result = 0;
            string query = "";
            if (dishExist(dishId, billId))
            {
                query = "UPDATE bill_item SET quantity = quantity + " + quantity
                        + " WHERE dish_id = " + dishId;
            }
            else
            {
                query = "INSERT INTO bill_item(dish_id,quantity,bill_id) VALUES ("
                        + dishId +"," + quantity + ","+ billId +")";
            }
            result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
    }
}
