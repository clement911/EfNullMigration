
using QuickBooksSharp.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class Purchase     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        [MaxLength(10)]
        public string PaymentType { get; set; }

        public long? AccountId { get; set; }

        [Column(TypeName = "char(3)")]
        public string Currency { get; set; }

        public DateOnly? Date { get; set; }

                public string PrintStatus { get; set; }

        #region RemitToAddr

        [MaxLength(30)]
        public string RemitToAddr_PostalCode { get; set; }

        [MaxLength(255)]
        public string RemitToAddr_City { get; set; }

        [MaxLength(255)]
        public string RemitToAddr_State { get; set; }

        [MaxLength(255)]
        public string RemitToAddr_Country { get; set; }

        [MaxLength(500)]
        
        public string RemitToAddr_Line1 { get; set; }

        [MaxLength(500)]
        
        public string RemitToAddr_Line2 { get; set; }

        [MaxLength(500)]
        
        public string RemitToAddr_Line3 { get; set; }

        [MaxLength(500)]
        
        public string RemitToAddr_Line4 { get; set; }

        [MaxLength(500)]
        
        public string RemitToAddr_Line5 { get; set; }

        
        
        public decimal? RemitToAddr_Lat { get; set; }

        
        
        public decimal? RemitToAddr_Long { get; set; }

        #endregion

                public string TxnSource { get; set; }

                public string GlobalTaxCalculation { get; set; }

                public string TransactionLocationType { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        [MaxLength(21)]
        public string DocNumber { get; set; }

        [MaxLength(4000)]
        public string PrivateNote { get; set; }

        public bool? Credit { get; set; }

        #region TxnTaxDetail

                public string TaxCodeId { get; set; }

        public decimal? TotalTax { get; set; }

        #endregion

        public long? PaymentMethodId { get; set; }

        public decimal? ExchangeRate { get; set; }

        public long? LocationId { get; set; }

        public long? CustomerId { get; set; }
        
        public long? VendorId { get; set; }
        
        public long? EmployeeId { get; set; }

        public bool? IncludeInAnnualTPAR { get; set; }

        public decimal? TotalAmt { get; set; }

        public long? RecurringTransactionId { get; set; }

    }
}
