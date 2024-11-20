using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.Models
{
    public class Offer
    {
        public int id { get; set; }
        public int name {  get; set; }
        public Offer() { }
        public Offer(int _id, int _name)
        {
            id = _id;
            name = _name;
        }

        //public Offer (int id) { m_offer_id = id; }
        //public void CheckOfferEligibility()
        //{

        //}
        //public void ApplyOffer() { } // nie wiem czy to tutaj powinno być, wyjdzie w praniu
    }
}
