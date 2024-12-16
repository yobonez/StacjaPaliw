using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StacjaPaliwLogic.Models;
using StacjaPaliwLogic.DataAccess;

namespace StacjaPaliwUI
{
    internal struct ProductStatistic
    {
        public string image { get; set; }
        public string name { get; set; }
        public Decimal amount_sold { get; set; }
        public Decimal income { get; set; }
        public string unit { get; set; }
    }
    internal class DataCruncher
    {
        public string dateRangeName { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public Decimal salesTotal { get; set; }
        List<ProductStatistic> top5_products { get; set; }

        IDataAccess<Transaction> trDA = new DataAccess<Transaction>();
        IDataAccess<TransactionItem> trItemDA = new DataAccess<TransactionItem>();
        IDataAccess<Product> prodDA = new DataAccess<Product>();
        
        private void GetTop5Products()
        {
            IEnumerable<Transaction> transactions = trDA.GetAllRows()
                                                        .Where(s => s.dateTime > from && s.dateTime < to);
            // TODO: transactions matching date and transitems matching transaction ids
            foreach (Transaction transaction in transactions)
            {

            }
        }
        private void GetSalesTotal()
        {
            IEnumerable<Transaction> transactions = trDA.GetAllRows()
                                                                 .Where(s => s.dateTime > from && s.dateTime < to);
            foreach (Transaction transaction in transactions)
            {
                salesTotal += transaction.value;
            }
        }
        public DataCruncher(string _dateRangeName, bool _isPrevious)
        {
            dateRangeName = _dateRangeName;
            DateTime now = DateTime.Now;

            if (dateRangeName == "dzień")
            {
                from = DateTimeUtils.StartOfDay(now, _isPrevious);
                to = DateTimeUtils.EndOfDay(now, _isPrevious);
            }
            else if (dateRangeName == "tydzień")
            {
                from = DateTimeUtils.StartOfWeek(now, _isPrevious);
                to = DateTimeUtils.EndOfDay(DateTimeUtils.StartOfWeek(now, _isPrevious).AddDays(6), _isPrevious);
            }
            else if (dateRangeName == "miesiąc") 
            {
                from = DateTimeUtils.StartOfMonth(now, _isPrevious);
                to = DateTimeUtils.EndOfMonth(now, _isPrevious);
            }
            else if (dateRangeName == "rok")
            {
                from = DateTimeUtils.StartOfYear(now, _isPrevious);
                to = DateTimeUtils.EndOfYear(now, _isPrevious);
            }

            GetSalesTotal();
        }
        public DataCruncher(DateTime _from, DateTime _to) 
        {
            from = _from;
            to = _to;

            GetSalesTotal();
            GetTop5Products();
        }
    }
}
