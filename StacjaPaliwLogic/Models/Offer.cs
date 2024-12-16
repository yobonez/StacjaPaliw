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
        public int card_id { get; set; }
        public int name {  get; set; }
        public string image { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public Offer() { }
        public Offer(int _id, int _name, int _offer_id, DateTime _from, DateTime _to)
        {
            id = _id;
            card_id = _offer_id;
            name = _name;
            from = _from;
            to = _to;
        }
    }
}
