
using System;
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class Budget     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateOnly? StartDate { get; set; }

        public DateOnly? EndDate { get; set; }

                public string BudgetEntryType { get; set; }

        [MaxLength(256)]
        public string Name { get; set; }

                public string BudgetType { get; set; }

        public bool? Active { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

    }
}
