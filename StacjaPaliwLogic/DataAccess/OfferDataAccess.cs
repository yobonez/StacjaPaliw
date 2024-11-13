using Newtonsoft.Json;
using StacjaPaliwLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.DataAccess
{
    public class OfferDataAccess : IDataAccess<Offer>
    {
        private List<Offer> offers;

        public OfferDataAccess()
        {

        }
        public List<Offer> Load()
        {
            offers = JsonConvert.DeserializeObject<List<Offer>>(File.ReadAllText(@"Offers.json"));
            return offers;
        }
        public Offer Read(int id)
        {
            foreach (Offer offer in offers)
            {
                if (offer.m_id == id) return offer;
            }
            throw new Exception("Nie ma takiego obiektu.");
        }


        public void Add(Offer row)
        {
            offers.Add(row);
        }
        public void Save()
        {
            File.WriteAllText(@$"{this.GetType().Name}.json", JsonConvert.SerializeObject(offers));
        }

    }
}
