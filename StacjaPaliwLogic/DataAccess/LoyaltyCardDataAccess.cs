using StacjaPaliwLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.DataAccess
{
    public class LoyaltyCardDataAccess : IDataAccess<LoyaltyCard>
    {
        private List<LoyaltyCard> loyalty_cards;
        public LoyaltyCardDataAccess()
        {

        }
        public List<LoyaltyCard> Load()
        {
            loyalty_cards = new List<LoyaltyCard>();
            // Ladowanie z pliku tabeli
        }
        public LoyaltyCard Read()
        {
            foreach (LoyaltyCard lcard in loyalty_cards)
            {
                //...
            }
            // Oczyt pojedynczego pola z Load()'niętej zmiennej
        }
        public void Add(LoyaltyCard row)
        {
            throw new NotImplementedException();
        }
    }
}
