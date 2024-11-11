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
            offers = new List<Offer>();
            // Ladowanie z pliku tabeli
        }
        public Offer Read()
        {
            foreach (Offer dist in offers)
            {
                //...
            }
            // Oczyt pojedynczego pola z Load()'niętej zmiennej
        }
        public void Add(Offer row)
        {

        }
    }
}
