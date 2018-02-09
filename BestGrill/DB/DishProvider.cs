using BestGrill.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGrill.DB
{
    class DishProvider : Provider
    {
        private static DishProvider instance;
        private DishProvider() { }
        public static DishProvider Instance
        {
            get { if (instance == null) instance = new DishProvider(); instance.Table = "dish"; return DishProvider.instance; }
            private set { DishProvider.instance = value; }
        }

        public List<Dish> loadDishByCategory(int categoryId)
        {
            List<Dish> listDish = new List<Dish>();
            string query = "SELECT * FROM dish WHERE category_id = " + categoryId;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                Dish tmp = new Dish(row);
                listDish.Add(tmp);
            }
            return listDish;
        }
    }
}
