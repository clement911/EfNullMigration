
using System;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    
    public class BudgetLine     {
        
        public long ConnectionId { get; set; }

        
        public long BudgetId { get; set; }

        public short Index { get; set; }

                public string ClassId { get; set; }

        public long? LocationId { get; set; }

        public decimal? Amount { get; set; }

        public DateOnly? BudgetDate { get; set; }

        public long? AccountId { get; set; }

        public long? CustomerId { get; set; }


    }
}
