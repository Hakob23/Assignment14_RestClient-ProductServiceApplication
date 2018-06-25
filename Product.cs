using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product
    {
        public Product()
        {

        }

       public Product(int id, string name, string category, int price)
        {
            ID = id;

            Name = name;

            Category = category;

            Price = price;

        }


        public int ID { get; set; }

        public int Price { get; set; }

        public string Category { get; set; }

        public string Name { get; set; }
    

    }
}
