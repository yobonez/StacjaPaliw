using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.Models
{
    //TODO: ProductPositions to Transaction
    // quantity, discount, etc
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int unit_id { get; set; }

        public Product() { }
        public Product(string _name, decimal _price, int _unit_id)
        {
            name = _name;
            price = _price;
            unit_id = _unit_id;
        }
    }
}
