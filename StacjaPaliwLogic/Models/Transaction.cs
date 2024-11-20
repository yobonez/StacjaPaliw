using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.Models
{
    public class Transaction
    {
        public int id { get; set; }
        public Decimal cart_value { get; set; }

        public Transaction() { }
        public Transaction(int _id, decimal _cart_value)
        {
            id = _id;
            cart_value = _cart_value;
        }


        //internal void ProceedTransaction() { }
    }
}
