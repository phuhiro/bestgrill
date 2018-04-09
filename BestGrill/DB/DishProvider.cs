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

        public List<Dish> loadAllDish()
        {
            List<Dish> lDish = new List<Dish>();
            string query = "SELECT dish.*,category.name as category_name FROM dish INNER JOIN category ON dish.category_id = category.id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Dish tmp = new Dish(row);
                lDish.Add(tmp);
            }
            return lDish;
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

        public bool addDish(string name,float price,int category_id)
        {
            string query = "INSERT INTO dish(name,price,category_id) VALUES ('"+name + "',"+price+","+category_id+")";
            
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0) return true;
            return false;
        }

        public int editDish(int dishId, string name, float price, int categoryId)
        {
            string query = "UPDATE dish SET name = '" + name + "'" + ", price="+ price+ ", category_id="+ categoryId 
                            + " WHERE id = "+dishId;

            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }

        public int deleteDish(int dishId)
        {
            string query = "DELETE FROM dish WHERE id = " + dishId;
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
    }
}
