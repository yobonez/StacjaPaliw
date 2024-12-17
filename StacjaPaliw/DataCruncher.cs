using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StacjaPaliwLogic.Models;
using StacjaPaliwLogic.DataAccess;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace StacjaPaliwUI
{
    public struct ProductStatistic
    {
        public string image { get; set; }
        public string name { get; set; }
        public Decimal amount_sold { get; set; }
        public Decimal income { get; set; }
        public string unit { get; set; }
    }
    class PSSortByAmountSold : IComparer<ProductStatistic>
    {
        public int Compare(ProductStatistic x, ProductStatistic y)
        {
            return y.amount_sold.CompareTo(x.amount_sold);
        }
    }

    class PSSortByIncome : IComparer<ProductStatistic>
    {
        public int Compare(ProductStatistic x, ProductStatistic y)
        {
            return y.income.CompareTo(x.income);
        }
    }

    internal class DataCruncher
    {
        public string dateRangeName { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public Decimal salesTotal { get; set; }
        public Decimal amountSoldTotal { get; set; }
        public List<ProductStatistic> selectedProducts { get; set; }

        IDataAccess<Transaction> trDA = new DataAccess<Transaction>();
        IDataAccess<TransactionItem> trItemDA = new DataAccess<TransactionItem>();
        IDataAccess<Product> prodDA = new DataAccess<Product>();
        IDataAccess<Unit> unitDA = new DataAccess<Unit>();
        
        public void SetTopProducts(bool bySold)
        {
            SortedSet<ProductStatistic> selectedProductsBySoldDesc = new SortedSet<ProductStatistic>(new PSSortByAmountSold());
            SortedSet<ProductStatistic> selectedProductsByIncomeDesc = new SortedSet<ProductStatistic>(new PSSortByIncome());
            IEnumerable<Transaction> transactionsFromToDate = trDA.GetAllRows()
                                                        .Where(s => s.dateTime > from && s.dateTime < to);

            List<TransactionItem> transactionItems = trItemDA.GetAllRows();
            List<Product> products = prodDA.GetAllRows();
            List<Unit> units = unitDA.GetAllRows();

            List<TransactionItem> matchingTrItems = new List<TransactionItem>();
            List<KeyValuePair<Product, Decimal>> productIncomes = new List<KeyValuePair<Product, Decimal>>();
            List<KeyValuePair<Product, Decimal>> productSolds = new List<KeyValuePair<Product, Decimal>>();

            foreach(Transaction transaction in transactionsFromToDate)
            {
                foreach(TransactionItem item in transactionItems)
                {
                    if (item.transaction_id == transaction.id)
                    {
                        matchingTrItems.Add(item);
                    }
                }
            }

            HashSet<Product> matchingProducts = new HashSet<Product>();
            foreach(Product product in products)
            {
                foreach (TransactionItem item in matchingTrItems)
                {
                    if (item.product_id == product.id)
                    {
                        productIncomes.Add(new KeyValuePair<Product, Decimal>(product, item.unit_amount * item.price_per_unit));
                        productSolds.Add(new KeyValuePair<Product, Decimal>(product, item.unit_amount));
                        matchingProducts.Add(product);
                    }
                }
            }

            //Dictionary<Product, Decimal> productIncomeTotals = new Dictionary<Product, Decimal>();
            //Dictionary<Product, Decimal> productSoldTotals = new Dictionary<Product, Decimal>();

            foreach(Product product in matchingProducts)
            {
                Decimal incomeTotal = 0;
                Decimal soldTotal = 0;
                foreach(KeyValuePair<Product, Decimal> item in productIncomes)
                {
                    if(product.id == item.Key.id)
                    {
                        incomeTotal += item.Value;
                    }
                }
                foreach (KeyValuePair<Product, Decimal> item in productSolds)
                {
                    if (product.id == item.Key.id)
                    {
                        soldTotal += item.Value;
                    }
                }

                //productIncomeTotals.Add(product, incomeTotal);
                //productSoldTotals.Add(product, soldTotal);


                selectedProductsByIncomeDesc.Add(new ProductStatistic()
                {
                    name = product.name,
                    amount_sold = soldTotal,
                    image = product.image,
                    income = incomeTotal,
                    unit = unitDA.ReadRow(product.unit_id).name
                });

                selectedProductsBySoldDesc.Add(new ProductStatistic()
                {
                    name = product.name,
                    amount_sold = soldTotal,
                    image = product.image,
                    income = incomeTotal,
                    unit = unitDA.ReadRow(product.unit_id).name
                });

                if(bySold)
                {
                    selectedProducts = selectedProductsBySoldDesc.ToList();
                }
                else
                {
                    selectedProducts = selectedProductsByIncomeDesc.ToList();
                }
            }
        }
        private void SetSalesTotal()
        {
            IEnumerable<Transaction> transactions = trDA.GetAllRows()
                                                                 .Where(s => s.dateTime > from && s.dateTime < to);

            List<TransactionItem> transactionItems = trItemDA.GetAllRows();
            List<TransactionItem> matchingTrItems = new List<TransactionItem>();

            foreach (Transaction transaction in transactions)
            {
                salesTotal += transaction.value;

                foreach (TransactionItem item in transactionItems)
                {
                    if (item.transaction_id == transaction.id)
                    {
                        matchingTrItems.Add(item);
                    }
                }
            }

            foreach(TransactionItem item in matchingTrItems)
            {
                amountSoldTotal += item.unit_amount;
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

            SetSalesTotal();
        }
        public DataCruncher(DateTime _from, DateTime _to) 
        {
            from = _from;
            to = _to;

            SetSalesTotal();
        }
    }
}
