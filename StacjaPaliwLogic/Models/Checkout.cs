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
        public int product_id { get; set; }
        public Decimal amount { get; set; }
        public Decimal discount { get; set; }
        
        public Checkout() { }
        public Checkout(int _id, int _product_id, Decimal _amount, Decimal _discount)
        {
            id = _id;
            product_id = _product_id;
            amount = _amount;
            discount = _discount;
        }

    }
}
