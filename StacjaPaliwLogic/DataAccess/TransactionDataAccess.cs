using Newtonsoft.Json;
using StacjaPaliwLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
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
            transactions = JsonConvert.DeserializeObject<List<Transaction>>(File.ReadAllText(@"Transactions.json"));
            return transactions;
        }
        public Transaction Read(int id)
        {
            foreach (Transaction transaction in transactions)
            {
                if(transaction.m_id == id) return transaction;
            }
            throw new Exception("Nie ma takiego obiektu.");
        }
        

        public void Add(Transaction row)
        {
            transactions.Add(row);
        }
        public void Save()
        {
            File.WriteAllText(@"Transactions.json", JsonConvert.SerializeObject(transactions));
        }
    }
}
