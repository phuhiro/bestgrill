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

        public bool addCate(string name)
        {
            string query = "INSERT INTO category(name) VALUES ('" + name + "')";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0) return true;
            return false;
        }

        public int editCate(int cateId, string name)
        {
            string query = "UPDATE category SET name = '" + name + "'" + " WHERE id = " + cateId;

            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }

        public int deleteCate(int cateId)
        {
            string query = "DELETE FROM category WHERE id = " + cateId;
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
    }
}
