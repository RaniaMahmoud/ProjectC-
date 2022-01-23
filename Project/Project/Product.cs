using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Product
    {
        #region Member
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Guarantee { get; set; }
        public string Category { get; set; }
        public string Store { get; set; }
        //public Category category { get; set; }
        #endregion
        #region Constructor
        public Product(string _name, double _price,int _Quantity, int _Guarantee/*,Category _catogory*/)
        {
            Name = _name;
            Price = _price;
            Quantity = _Quantity;
            Guarantee = _Guarantee;
            //category = _catogory;
        }
        public Product(string _name, double _price, int _Quantity, int _Guarantee, string _coteg )
        {
            Name = _name;
            Price = _price;
            Quantity = _Quantity;
            Guarantee = _Guarantee;
            Category = _coteg;
        }
        public Product()
        {
            //category = new Category();          
        }
        #endregion

    }
}
