using BestGrill.DB;
using BestGrill.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestGrill
{
    public partial class AdminUi : Form
    {
        public AdminUi()
        {
            InitializeComponent();
            dvProfit.Columns[2].DefaultCellStyle.Format = "c2";
            dvProfit.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");
            dvProfit.Columns[3].DefaultCellStyle.Format = "c2";
            dvProfit.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN"); 
            dvProfit.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void loadDish()
        {
            dishBindingSource.Clear();
            var lDish = DishProvider.Instance.loadAllDish();
            foreach (Dish d in lDish)
            {
                dishBindingSource.Add(d);
            }
        }

        private void loadDefaultProfilt()
        {
            float total = 0;
            DateTime from = DateTime.Today;
            DateTime to = DateTime.Today;
            billBindingSource.Clear();
            var lBill = BillProvider.Instance.loadBill(from, to);
            foreach (Bill b in lBill)
            {
                total += b.Total;
                billBindingSource.Add(b);
            }
            lbTotalBill.Text = total.ToString("c2", CultureInfo.GetCultureInfo("vi-VN"));
        }
        private void loadCate()
        {

            categoryBindingSource.Clear();
            var lCate = CategoryProvider.Instance.loadCategoryList();
            foreach (Category c in lCate)
            {
                categoryBindingSource.Add(c);
            }
        }
        private void AdminUi_Load(object sender, EventArgs e)
        {
            loadDish();
            loadCate();
            loadDefaultProfilt();
            loadCategoryToCombox();
        }

        private void loadCategoryToCombox()
        {
            var categories = CategoryProvider.Instance.loadCategoryList();
            foreach(var cate in categories)
            {
                cbDishCategory.Items.Add(cate);
            }
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            string dName = tbDishName.Text;
            float dPrice = float.Parse(tbDishPrice.Text);
            int categoryId = 1;
            DishProvider.Instance.addDish(dName, dPrice, categoryId);
            loadDish();
        }

        private void btnEditDish_Click(object sender, EventArgs e)
        {
            int dishId = int.Parse(tbDishID.Text);
            string dName = tbDishName.Text;
            float dPrice = float.Parse(tbDishPrice.Text);
            int categoryId = 1;
            DishProvider.Instance.editDish(dishId, dName, dPrice, categoryId);
            loadDish();
        }

        private void btnDeleteDish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa " + tbDishName.Text, "Xóa món", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
                int dishId = int.Parse(tbDishID.Text);
                DishProvider.Instance.deleteDish(dishId);
                loadDish();
            };
        }

        private void dvDishAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowSelected = dvDishAdmin.SelectedRows[0];
            string id = rowSelected.Cells["dishIDCol"].Value.ToString();
            string dName = rowSelected.Cells["DishName"].Value.ToString();
            string dPrice = rowSelected.Cells["priceCol"].Value.ToString();
            tbDishID.Text = id;
            tbDishName.Text = dName;
            tbDishPrice.Text = dPrice;
        }

        private void dvCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowSelected = dvCate.SelectedRows[0];
            string id = rowSelected.Cells["cateIdDv"].Value.ToString();
            string cName = rowSelected.Cells["cateNameDv"].Value.ToString();
            tbCateId.Text = id;
            tbCateName.Text = cName;
        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            string cName = tbCateName.Text;
            CategoryProvider.Instance.addCate(cName);
            loadCate();
        }

        private void btnEditCate_Click(object sender, EventArgs e)
        {
            int cateId = int.Parse(tbCateId.Text);
            string cName = tbCateName.Text;
            CategoryProvider.Instance.editCate(cateId, cName);
            loadCate();
        }

        private void btnDeleteCate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa " + tbCateName.Text, "Xóa danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int cateId = int.Parse(tbCateId.Text);
                DishProvider.Instance.deleteDish(cateId);
                 loadCate();
            };
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            float total = 0;
            DateTime from = dtpFrom.Value;
            DateTime to = dtpTo.Value;
            billBindingSource.Clear();
            var lBill = BillProvider.Instance.loadBill(from, to);
            foreach (Bill b in lBill)
            {
                total += b.Total;
                billBindingSource.Add(b);
            }
            lbTotalBill.Text = total.ToString("c2", CultureInfo.GetCultureInfo("vi-VN"));
        }
    }
}
