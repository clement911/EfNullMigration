
using QuickBooksSharp.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class Bill     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public long? VendorId { get; set; }

        [Column(TypeName = "char(3)")]
        public string Currency { get; set; }

        public DateOnly? Date { get; set; }

        public long? APAccountId { get; set; }

        public long? SalesTermId { get; set; }

                public string GlobalTaxCalculation { get; set; }

        public decimal? TotalAmt { get; set; }

                public string TransactionLocationType { get; set; }

        public DateOnly? DueDate { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        [MaxLength(21)]
        public string DocNumber { get; set; }

        [MaxLength(4000)]
        public string PrivateNote { get; set; }

        public decimal? ExchangeRate { get; set; }

        public long? LocationId { get; set; }

        public bool? IncludeInAnnualTPAR { get; set; }

        public decimal? HomeBalance { get; set; }

        public long? RecurringTransactionId { get; set; }

        public decimal? Balance { get; set; }

        #region TxnTaxDetail

                public string TaxCodeId { get; set; }

        public decimal? TotalTax { get; set; }

        #endregion


    }
}
