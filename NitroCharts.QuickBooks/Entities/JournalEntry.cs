
using QuickBooksSharp.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class JournalEntry     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        [Column(TypeName = "char(3)")]
        public string Currency { get; set; }

        [MaxLength(21)]
        public string DocNumber { get; set; }

        [MaxLength(4000)]
        public string PrivateNote { get; set; }

        public DateOnly? TxnDate { get; set; }

        public decimal? ExchangeRate { get; set; }

                public string TransactionLocationType { get; set; }

                public string TaxCodeId { get; set; }

        public decimal? TotalTax { get; set; }

                public string GlobalTaxCalculation { get; set; }

        public bool? Adjustment { get; set; }

        public long? RecurringTransactionId { get; set; }

        public decimal? TotalAmt { get; set; }

        public decimal? HomeTotalAmt { get; set; }

        
    }
}
