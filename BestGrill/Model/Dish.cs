using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestGrill.Model
{
    class Dish
    {
        public Dish(int id, string name, float price)
        {
            this.iD = id;
            this.name = name;
            this.price = price;
        }

        public Dish(DataRow row)
        {
            this.iD = (int) row["id"];
            this.name = row["name"].ToString();
            this.price = (float) row["price"];
            this.category = (int)row["category_id"];
            this.cateName = row.Table.Columns.Contains("category_name") == true ? row["category_name"].ToString() : "";
        }
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private int category;

        public int Category
        {
            get { return category; }
            set { category = value; }
        }

        private string cateName;

        public string CateName
        {
            get { return cateName; }
            set { cateName = value; }
        }
    }
}
