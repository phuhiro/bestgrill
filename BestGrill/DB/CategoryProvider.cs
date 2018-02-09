using BestGrill.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGrill.DB
{
    class CategoryProvider : Provider
    {
        private static CategoryProvider instance;
        private CategoryProvider() { }
        public static CategoryProvider Instance
        {
            get { if (instance == null) instance = new CategoryProvider(); instance.Table = "category"; return CategoryProvider.instance; }
            private set { CategoryProvider.instance = value; }
        }

        public List<Category> loadCategoryList()
        {
            List<Category> categoryList = new List<Category>();
            DataTable data = this.getAll();
            foreach (DataRow row in data.Rows)
            {
                Category tmp = new Category(row);
                categoryList.Add(tmp);
            }
            return categoryList;
        }
    }
}
