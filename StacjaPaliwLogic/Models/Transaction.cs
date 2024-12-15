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
        private Decimal _value;
        public Decimal value {
            get { return _value; }
            set { _value = Math.Round(value, 2); }
        }

        private Decimal _discounts_value;
        public Decimal discounts_value
        {
            get { return _discounts_value; }
            set { _discounts_value = Math.Round(value, 2); }
        }

        public DateTime dateTime { get; set; }

        public Transaction() { }
        public Transaction(decimal _value, decimal _discounts_value)
        {
            value = _value;
            discounts_value = _discounts_value;
        }
    }
}
