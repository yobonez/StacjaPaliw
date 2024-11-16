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
        public List<OfferChallenge> challenges { get; set; }

        public Offer() { }
        public Offer(int id, List<OfferChallenge> challenges)
        {
            id = id;
            challenges = challenges;
        }

        //public Offer (int id) { m_offer_id = id; }
        //public void CheckOfferEligibility()
        //{

        //}
        //public void ApplyOffer() { } // nie wiem czy to tutaj powinno być, wyjdzie w praniu
    }
}
