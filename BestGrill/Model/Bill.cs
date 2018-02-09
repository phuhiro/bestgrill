using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGrill.Model
{
    class Bill
    {

        private Int64 iD;

        public Int64 ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        private List<BillItem> lBillItem;

        public List<BillItem> LBillItem
        {
            get { return lBillItem; }
            set { lBillItem = value; }
        }

        private int tableId;

        public int TableId
        {
          get { return tableId; }
          set { tableId = value; }
        }

        private float subTotal;

        public float SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }
        private float discount;

        public float Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        private float total;

        public float Total
        {
            get { return total; }
            set { total = value; }
        }

        private DateTime created_at;

        public DateTime Created_at
        {
            get { return created_at; }
            set { created_at = value; }
        }

        private DateTime checkout_at;

        public DateTime Checkout_at
        {
            get { return checkout_at; }
            set { checkout_at = value; }
        }

        public Bill(DataRow row)
        {
            this.tableId = (int)row["table_id"];
            this.iD = (Int64)row["id"];
            this.status = (bool)row["status"];
            this.subTotal = (float)row["subtotal"];
            this.discount = (float)row["discount"];
            this.total = (float)row["total"];
            this.created_at = (DateTime)row["created_at"];
            if (this.status) this.checkout_at = (DateTime)row["checkout_at"];
        }
    }
}
