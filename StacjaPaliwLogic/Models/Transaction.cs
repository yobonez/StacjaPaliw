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

        public Transaction() { }
        public Transaction(decimal _value)
        {
            value = _value;
        }


        //internal void ProceedTransaction() { }
    }
}
