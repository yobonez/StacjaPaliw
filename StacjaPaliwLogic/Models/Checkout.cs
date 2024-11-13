using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.Models
{
    public class Checkout
    {
        public int m_id;
        public List<Product> m_product_list;
        public double m_value;

        Checkout(List<Product> lista_produktow)
        {

        }

    }
}
