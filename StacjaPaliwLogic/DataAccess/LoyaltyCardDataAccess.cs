using StacjaPaliwLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.DataAccess
{
    public class LoyaltyCardDataAccess : IDataAccess
    {
        private List<IDataAccess> loyalty_cards;

        List<IDataAccess> Load()
        {
            throw new NotImplementedException();
        }

        public IDataAccess Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IDataAccess row)
        {
            throw new NotImplementedException();
        }

    }
}
