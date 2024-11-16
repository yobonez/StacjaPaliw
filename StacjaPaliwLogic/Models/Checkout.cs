using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.Models
{
    public class Checkout
    {
        public int id { get; set; }
        public List<Product> product_list { get; set; }
        public double value { get; set; }

        Checkout(int _id ,List<Product> _product_list, double _value)
        {
            id = _id;
            product_list = _product_list;
            value = _value;
        }

    }
}
