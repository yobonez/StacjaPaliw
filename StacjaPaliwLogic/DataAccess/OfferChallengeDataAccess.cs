using StacjaPaliwLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.DataAccess
{
    public class OfferChallengeDataAccess : IDataAccess<OfferChallenge>
    {
        private List<OfferChallenge> offer_challenges;
        public OfferChallengeDataAccess()
        {

        }
        public List<OfferChallenge> Load()
        {
            offer_challenges = new List<OfferChallenge>();

            throw new NotImplementedException();
        }
        public OfferChallenge Read()
        {
            foreach (OfferChallenge ochallenge in offer_challenges)
            {
                //...
            }
            // Oczyt pojedynczego pola z Load()'niętej zmiennej
        }

        public void Add(OfferChallenge row)
        {
            throw new NotImplementedException();
        }
    }
}
