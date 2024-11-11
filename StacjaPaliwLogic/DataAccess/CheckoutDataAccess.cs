using StacjaPaliwLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.DataAccess
{
    public class CheckoutDataAccess : IDataAccess<Checkout>
    {
        private Checkout checkout;

        public CheckoutDataAccess()
        {
            
        }

        public void Add(Checkout row)
        {
            throw new NotImplementedException();
        }

        public List<Checkout> Load()
        {
            throw new NotImplementedException();
        }

        public Checkout Read()
        {
            throw new NotImplementedException();
        }
    }
}
