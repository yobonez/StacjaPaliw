using StacjaPaliwLogic.DataAccess;
using StacjaPaliwLogic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwUI
{
    internal class StacjaPaliwStatus
    {
        public static Transaction transaction { get; set; } = new Transaction();
        public static List<TransactionItem> transactionItems { get; set; } = new List<TransactionItem>();
        public static BindingList<CheckoutDisplayItem> checkoutItems = new BindingList<CheckoutDisplayItem>();

        public static void resetStatus()
        {
            transaction = new Transaction();
            transaction.id = DataAccess<Transaction>._availableId;
            transactionItems = new List<TransactionItem>();
            checkoutItems = new BindingList<CheckoutDisplayItem>();
        }
    }
}
