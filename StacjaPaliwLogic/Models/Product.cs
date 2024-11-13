using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.Models
{
    public class Product
    {
        public int m_id { get; set; }
        public string m_name { get; set; }
        public decimal m_price { get; set; }
        public decimal m_discount { get; set; }
        public int m_unit_id { get; set; }
        public decimal m_quantity { get; set; }

        
    }
}
