using StacjaPaliwLogic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.DataAccess
{
    internal class DistributorDataAccess : IDataAccess<Distributor>
    {
        private List<Distributor> distributors;
        public DistributorDataAccess() 
        { 
            
        }
        public List<Distributor> Load()
        {
            distributors = new List<Distributor>();
            // Ladowanie z pliku tabeli
        }
        public Distributor Read()
        {
            foreach (Distributor dist in distributors)
            {
                //...
            }
            // Oczyt pojedynczego pola z Load()'niętej zmiennej
        }
        
        public void Add(Distributor row)
        {
            throw new NotImplementedException();
        }
        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
