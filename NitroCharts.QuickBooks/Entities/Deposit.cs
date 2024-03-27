
using QuickBooksSharp.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class Deposit     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public long? DepositToAccountId { get; set; }

        [Column(TypeName = "char(3)")]
        public string Currency { get; set; }

        [MaxLength(4000)]
        public string PrivateNote { get; set; }

                public string GlobalTaxCalculation { get; set; }

        public decimal? ExchangeRate { get; set; }

        public long? LocationId { get; set; }

                public string TxnSource { get; set; }

        public DateOnly? TxnDate { get; set; }

        public long? CashBack_AccountId { get; set; }

        public decimal? CashBack_Amount { get; set; }

        [MaxLength(255)]
        public string CashBack_Memo { get; set; }

                public string TransactionLocationType { get; set; }

                public string TaxCodeId { get; set; }

        public decimal? TotalTax { get; set; }

        public long? RecurringTransactionId { get; set; }

        public decimal? TotalAmt { get; set; }

        public decimal? HomeTotalAmt { get; set; }

    }
}
