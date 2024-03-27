
using QuickBooksSharp.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class ReimburseCharge     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public decimal? Amount { get; set; }

        public long? CustomerId { get; set; }

        [Column(TypeName = "char(3)")]
        public string Currency { get; set; }

        [MaxLength(4000)]
        public string PrivateNote { get; set; }

        public decimal? ExchangeRate { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public bool? HasBeenInvoiced { get; set; }

        public decimal? HomeTotalAmt { get; set; }

        public DateOnly? TxnDate { get; set; }

    }
}
