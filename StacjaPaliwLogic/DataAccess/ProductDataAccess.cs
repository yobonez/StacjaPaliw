using StacjaPaliwLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwLogic.DataAccess
{
    public class ProductDataAccess : IDataAccess<Product>
    {
        private List<Product> products;
        public ProductDataAccess()
        {

        }
        public List<Product> Load()
        {
            products = new List<Product>();
            // Ladowanie z pliku tabeli
        }
        public Product Read()
        {
            foreach (Product prod in products)
            {
                //...
            }
            // Oczyt pojedynczego pola z Load()'niętej zmiennej
        }
        public void Add(Product row)
        {
            throw new NotImplementedException();
        }
    }
}
