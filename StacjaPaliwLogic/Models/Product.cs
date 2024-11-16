using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public decimal discount { get; set; }
        public int unit_id { get; set; }
        public decimal quantity { get; set; }

        public Product()
        {

        }
        public Product(int _id, string _name, decimal _price, decimal _discount, int _unit_id, decimal _quantity)
        {
            id = _id;
            name = _name;
            price = _price;
            discount = _discount;
            unit_id = _unit_id;
            quantity = _quantity;
        }
    }
}
