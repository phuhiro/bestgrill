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
            var rowSelected = dvDishAdmin.SelectedRows[0];
            string id = rowSelected.Cells["dishIDCol"].Value.ToString();
            string dName = rowSelected.Cells["DishName"].Value.ToString();
            string dPrice = rowSelected.Cells["priceCol"].Value.ToString();
            tbDishID.Text = id;
            tbDishName.Text = dName;
            tbDishPrice.Text = dPrice;
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            string dName = tbDishName.Text;

        }
    }
}
