using StacjaPaliwLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacjaPaliwUI
{
    internal class StacjaPaliwStatus
    {
        public static Transaction transaction { get; set; } = new Transaction();
        public static List<TransactionItem> transactionItems { get; set; } = new List<TransactionItem>();
        public static BindingSource transactionBindingSource { get; set; } = new BindingSource();
    }
}
