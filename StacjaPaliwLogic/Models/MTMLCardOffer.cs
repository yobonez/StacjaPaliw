using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.Models
{
    public class MTMLCardOffer
    {
        public int id {  get; set; }
        public int loyalty_card_id { get; set; }
        public int offer_id  { get; set; }

        public MTMLCardOffer() { }
        public MTMLCardOffer(int _id, int _loyalty_card_id, int _offer_id)
        {
            id = _id;
            loyalty_card_id = _loyalty_card_id;
            offer_id = _offer_id;
        }
    }
}
