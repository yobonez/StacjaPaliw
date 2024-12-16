using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.Models
{
    public class OfferChallenge
    {
        public int id { get; set; }
        public int offer_id { get; set; }
        public string challenged_prop { get; set; }
        private Decimal _cmp_value;
        public Decimal cmp_value {
            get { return _cmp_value; }
            set { _cmp_value = Math.Round(value, 2); }
        }
        public char cmp_equator { get; set; }

        public Decimal discount_to_apply { get; set; }
        public bool numerical_or_percentage { get; set; }
        
        public OfferChallenge() { }
        public OfferChallenge(int _id, int _offer_id, string _challenged_prop, Decimal _cmp_value, char _cmp_equator, Decimal _discount_to_apply, bool _numerical_or_percentage)
        {
            id = _id;
            offer_id = _offer_id;
            challenged_prop = _challenged_prop;
            cmp_value = _cmp_value;
            cmp_equator = _cmp_equator;
            discount_to_apply = _discount_to_apply;
            numerical_or_percentage = _numerical_or_percentage;
        }
    }
}
