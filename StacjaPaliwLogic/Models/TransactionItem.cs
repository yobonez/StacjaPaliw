namespace StacjaPaliwLogic.Models
{
    public class TransactionItem
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public int transaction_id { get; set; }

        private Decimal _price_per_unit;
        public Decimal price_per_unit
        {
            get { return _price_per_unit; }
            set { _price_per_unit = Math.Round(value, 2); }
        }
        private Decimal _unit_amount;
        public Decimal unit_amount {
            get { return _unit_amount; }
            set { _unit_amount = Math.Round(value, 2); }
        }
        private Decimal _discount;
        public Decimal discount {
            get { return _discount; }
            set { _discount = Math.Round(value, 2); }
        }
        
        public TransactionItem() { }
        public TransactionItem(int _product_id, int _transaction_id, Decimal _price_per_unit ,Decimal _unit_amount, Decimal _discount)
        {
            product_id = _product_id;
            transaction_id = _transaction_id;
            price_per_unit = _price_per_unit;
            unit_amount = _unit_amount;
            discount = _discount;
        }

    }
}
