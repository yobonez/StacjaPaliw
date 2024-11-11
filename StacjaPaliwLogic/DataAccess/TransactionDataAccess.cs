using StacjaPaliwLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Transactions może kolidować z System.Transactions

namespace StacjaPaliwLogic.DataAccess
{
    public class TransactionDataAccess : IDataAccess<Transaction>
    {
        private List<Transaction> transactions;
        public TransactionDataAccess()
        {

        }
        public List<Transaction> Load()
        {
            transactions = new List<Transaction>();
            // Ladowanie z pliku tabeli
        }
        public Transaction Read()
        {
            foreach (Transaction dist in transactions)
            {
                //...
            }
            // Oczyt pojedynczego pola z Load()'niętej zmiennej
        }
        

        public void Add(Transaction row)
        {
            throw new NotImplementedException();
        }
    }
}
