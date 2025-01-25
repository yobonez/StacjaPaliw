namespace StacjaPaliwLogic.Models
{
    public class CardOffer
    {
        public int id {  get; set; }
        public int loyalty_card_id { get; set; }
        public int offer_id  { get; set; }

        public CardOffer() { }
        public CardOffer(int _id, int _loyalty_card_id, int _offer_id)
        {
            id = _id;
            loyalty_card_id = _loyalty_card_id;
            offer_id = _offer_id;
        }
    }
}
