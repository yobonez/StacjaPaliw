using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StacjaPaliwLogic.Models;
using StacjaPaliwLogic.DataAccess;

namespace StacjaPaliwUI
{
    internal class DataCruncher
    {
        public string dateRangeName { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public Decimal salesTotal { get; set; }

       
        private void GetSalesTotal()
        {
            IDataAccess<Transaction> transactionDA = new DataAccess<Transaction>();
            IEnumerable<Transaction> transactions = transactionDA.GetAllRows()
                                                                 .Where(s => s.dateTime > );


        }
        DataCruncher(string _dateRangeName, bool _isPrevious)
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
        }
        DataCruncher(DateTime from, DateTime to) 
        {
        }
    }
}
