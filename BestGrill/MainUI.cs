using BestGrill.DataGridViewNumericUpDownElements;
using BestGrill.DB;
using BestGrill.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestGrill
{
    public partial class MainUI : Form
    {
        private static int tableSelected = 0;
        private Int64 billSelected = 0;
        public MainUI()
        {
            InitializeComponent();
            LoadTabeList();
            LoadCategoryList();
            dvBill.Visible = false;
            IntForm();
        }
        #region Methods
        /// <summary>
        /// Hàm gọi load danh sách cách bàn lên FloatLayoutTable
        /// </summary>
        public void LoadTabeList()
        {
            fltb.Controls.Clear();
            List<Table> tableList = TableProvider.Instance.loadTableList();
            foreach (Table table in tableList)
            {
                Button btnTable = new Button();
                btnTable.Width = 80;
                btnTable.Height = 80;
                if (table.Status == true)
                {
                    btnTable.Text = table.Name + Environment.NewLine + "Đang dùng";
                    btnTable.BackColor = Color.FromName(ConfigurationManager.AppSettings.Get("colorTableDirty"));

                }
                else
                {
                    btnTable.Text = table.Name + Environment.NewLine + "Trống";
                    btnTable.BackColor = Color.FromName(ConfigurationManager.AppSettings.Get("colorTableEmty"));

                }
                btnTable.Click += btnTable_Click;
                btnTable.Tag = table;
                fltb.Controls.Add(btnTable);
            }
        }
        /// <summary>
        /// Khoi tao trang thai dau cua Form
        /// </summary>
        public void IntForm()
        {
            if (tableSelected == 0)
            {
                btnAddDish.Enabled = false;
            }
            if(billSelected == 0)
            {
                btnPay.Enabled = false;
            }
        }

        public void LoadCategoryList()
        {
            List<Category> categoryList = CategoryProvider.Instance.loadCategoryList();
            cbCategory.DataSource = categoryList;
            cbCategory.DisplayMember = "Name";
        }

        public void LoadDishByCategoryId(int categoryId)
        {
            dishBindingSource.Clear();
            List<Dish> listDish = new List<Dish>();
            listDish = DishProvider.Instance.loadDishByCategory(categoryId);
            foreach(Dish d in listDish)
            {
                dishBindingSource.Add(d);
            }
            dvDish.ClearSelection();
        }

        public void ResetBillPanel()
        {
            lbSubTotal.Text = "0";
            lbDiscount.Text = "0";
            lbVat.Text = "0%";
            lbTotal.Text = "0";
            lbEmptyBill.Text = "Chưa gọi món";
            lbEmptyBill.Visible = true;
            dvBill.Visible = false;
        }

        public void LoadBillItem(Int64 billId)
        {
            float totalBill = 0;
            billItemBindingSource.Clear();
            List<BillItem> listBillItem = BillItemProvider.Instance.loadBillItemById(billId);
            foreach(BillItem item in listBillItem)
            {
                billItemBindingSource.Add(item);
                totalBill += item.Total;
            }
            lbEmptyBill.Visible = false;
            lbSubTotal.Text = totalBill.ToString();
            dvBill.Visible = true;
        }

        public void AddDishToBill()
        {
            var row = dvDish.SelectedRows[0];
            int dishId = (int)(row.Cells[0].Value);
            int quantity = (int)numDish.Value;
            BillItemProvider.Instance.AddDishToBill(dishId, quantity, this.billSelected);
            LoadBillItem(this.billSelected);
        }

        public Int64 CreateNewBill()
        {
            Int64 id = 0;
            id = BillProvider.Instance.CreateBill(tableSelected);
            TableProvider.Instance.UpdateStatus(tableSelected, 1);
            this.LoadTabeList();
            return id;
        }

        public void PayBill(Int64 billId)
        {
            float subTotal = float.Parse(lbSubTotal.Text.ToString());
            float discount = float.Parse(lbDiscount.Text.ToString());
            float total = float.Parse(lbTotal.Text.ToString());
            BillProvider.Instance.PayBill(billId, subTotal, discount, total);
            TableProvider.Instance.UpdateStatus(tableSelected,0);
            this.LoadTabeList();
            this.ResetBillPanel();
            this.IntForm();
        }
        #endregion
        #region Events
        private void btnRefreshListTable_Click(object sender, EventArgs e)
        {
            LoadTabeList();
        }
        #endregion

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadDishByCategoryId(id);

        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            // Enable Button AddDish
            btnAddDish.Enabled = true;
            // Enable Thanh toan button
            btnPay.Enabled = true;
            Table selected = (sender as Button).Tag as Table;
            string name = selected.Name;
            int tableId = selected.ID;
            tableSelected = tableId;
            lbTableSelected.Text = name;
            lbTableSelected.Font = new Font(lbTableSelected.Font.Name, 12, FontStyle.Bold);
            DataTable data = BillProvider.Instance.LoadBillByTableId(tableId);
            if (data.Rows.Count == 0)
            {
                ResetBillPanel();
                this.billSelected = 0;
                return;
            }
            Bill billSelected = new Bill(data.Rows[0]);
            Int64 billId = billSelected.ID;
            this.billSelected = billId;
            LoadBillItem(billId);
        }

        private void dvDish_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = dvDish.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;
            var row = dvDish.SelectedRows[0];
            if (row == null) return;
            lbDishSelected.Text = row.Cells[1].Value.ToString();
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            if(this.billSelected == 0)
            {
                this.billSelected = CreateNewBill();
            }

            AddDishToBill();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            PayBill(this.billSelected);
        }

    }
}
