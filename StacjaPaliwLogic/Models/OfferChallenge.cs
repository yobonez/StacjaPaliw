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
        public Decimal cmp_value { get; set; }
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
