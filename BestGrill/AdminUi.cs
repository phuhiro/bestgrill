using BestGrill.DB;
using BestGrill.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private void AdminUi_Load(object sender, EventArgs e)
        {
            loadDish();
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
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
 
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
    }
}
