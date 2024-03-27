
using System;
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class TaxPayment     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public bool? Refund { get; set; }

        public DateOnly? PaymentDate { get; set; }

        public long? PaymentAccountId { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }

        public decimal? PaymentAmount { get; set; }


    }
}
