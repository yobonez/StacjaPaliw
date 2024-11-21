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
        private Decimal _cmp_value;
        public Decimal cmp_value {
            get { return _cmp_value; }
            set { _cmp_value = Math.Round(value, 2); }
        }
        public char cmp_equator { get; set; }
        
        public OfferChallenge() { }
        public OfferChallenge(int _id, int _offer_id, Decimal _cmp_value, char _cmp_equator)
        {
            id = _id;
            offer_id = _offer_id;
            cmp_value = _cmp_value;
            cmp_equator = _cmp_equator;
        }


        //public bool VerifyChallenge() { return false; }
    }
}
