namespace StacjaPaliwLogic.Models
{
    //TODO: ProductPositions to Transaction
    // quantity, discount, etc
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        private Decimal _price;
        public Decimal price {
            get { return _price; }
            set { _price = Math.Round(value, 2); }
        }
        public int unit_id { get; set; }

        public Product() { }
        public Product(string _name, decimal _price, int _unit_id)
        {
            name = _name;
            price = _price;
            unit_id = _unit_id;
        }
    }
}
