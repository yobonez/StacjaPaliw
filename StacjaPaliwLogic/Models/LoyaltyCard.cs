namespace StacjaPaliwLogic.Models
{
    public class LoyaltyCard
    {
        public int id { get; set; }
        public int client_id { get; set; }
        public int points { get; set; }
        public DateTime card_opened { get; set; }

        public LoyaltyCard() { }
        public LoyaltyCard(int _id, int _client_id, string _name, string _surname, int _points, DateTime _card_opened)
        {
            id = _id;
            client_id = _client_id;
            points = _points;
            card_opened = _card_opened;
        }
    }
}
