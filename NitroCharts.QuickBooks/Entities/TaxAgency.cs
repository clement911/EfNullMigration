
using System;
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class TaxAgency     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        [MaxLength(100)]
        public string DisplayName { get; set; }

        public bool? TaxTrackedOnSales { get; set; }

        public bool? TaxTrackedOnPurchases { get; set; }

        public DateOnly? LastFileDate { get; set; }

        [MaxLength(100)]
        
        public string TaxRegistrationNumber { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

                public string TaxAgencyConfig { get; set; }

    }
}
