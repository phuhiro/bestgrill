using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGrill.Model
{
    class BillItem
    {
        private Int64 iD;

        public Int64 ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private int dishId;

        public int DishId
        {
            get { return dishId; }
            set { dishId = value; }
        }

        private string dishName;

        public string DishName
        {
            get { return dishName; }
            set { dishName = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private float total;

        public float Total
        {
            get { return total; }
            private set { total = value; }
        }

        private int billId;

        public int BillId
        {
            get { return billId; }
            set { billId = value; }
        }
        public BillItem(DataRow row)
        {
            this.iD = (Int64)row["id"];
            this.quantity = (int)row["quantity"];
            this.dishName = row["name"].ToString();
            float price = (float)row["price"];
            this.total = price * this.quantity;
        }
    }
}
