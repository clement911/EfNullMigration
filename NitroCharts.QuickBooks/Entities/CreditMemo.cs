
using QuickBooksSharp.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class CreditMemo     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public long? CustomerId { get; set; }

        [Column(TypeName = "char(3)")]
        public string Currency { get; set; }

        [MaxLength(128)]
        
        public string BillEmailAddress { get; set; }

        public DateOnly? TxnDate { get; set; }

        [MaxLength(31)]
        public string CustomField1 { get; set; }

        [MaxLength(31)]
        public string CustomField2 { get; set; }

        [MaxLength(31)]
        public string CustomField3 { get; set; }

                public string ClassId { get; set; }

                public string PrintStatus { get; set; }

        public long? SalesTermId { get; set; }

                public string GlobalTaxCalculation { get; set; }

        public decimal? TotalAmt { get; set; }

        public long? InvoiceId { get; set; }

        [MaxLength(24)]
        public string TransactionLocationType { get; set; }

        public bool? ApplyTaxAfterDiscount { get; set; }

        [MaxLength(21)]
        public string DocNumber { get; set; }

        [MaxLength(4000)]
        public string PrivateNote { get; set; }

        [MaxLength(1024)]
        public string CustomerMemo { get; set; }

                public string TaxCodeId { get; set; }

        public decimal? TotalTax { get; set; }

        public long? PaymentMethodId { get; set; }

        public decimal? ExchangeRate { get; set; }

        [MaxLength(30)]
        public string ShipToAddr_PostalCode { get; set; }

        [MaxLength(255)]
        public string ShipToAddr_City { get; set; }

        [MaxLength(255)]
        public string ShipToAddr_State { get; set; }

        [MaxLength(255)]
        public string ShipToAddr_Country { get; set; }

        [MaxLength(500)]
        
        public string ShipToAddr_Line1 { get; set; }

        [MaxLength(500)]
        
        public string ShipToAddr_Line2 { get; set; }

        [MaxLength(500)]
        
        public string ShipToAddr_Line3 { get; set; }

        [MaxLength(500)]
        
        public string ShipToAddr_Line4 { get; set; }

        [MaxLength(500)]
        
        public string ShipToAddr_Line5 { get; set; }

        
        
        public decimal? ShipToAddr_Lat { get; set; }

        
        
        public decimal? ShipToAddr_Long { get; set; }

        public long? LocationId { get; set; }

                public string EmailStatus { get; set; }

        [MaxLength(30)]
        public string BillAddr_PostalCode { get; set; }

        [MaxLength(255)]
        public string BillAddr_City { get; set; }

        [MaxLength(255)]
        public string BillAddr_State { get; set; }

        [MaxLength(255)]
        public string BillAddr_Country { get; set; }

        [MaxLength(500)]
        
        public string BillAddr_Line1 { get; set; }

        [MaxLength(500)]
        
        public string BillAddr_Line2 { get; set; }

        [MaxLength(500)]
        
        public string BillAddr_Line3 { get; set; }

        [MaxLength(500)]
        
        public string BillAddr_Line4 { get; set; }

        [MaxLength(500)]
        
        public string BillAddr_Line5 { get; set; }

        
        
        public decimal? BillAddr_Lat { get; set; }

        
        
        public decimal? BillAddr_Long { get; set; }

        public decimal? HomeBalance { get; set; }

        public decimal? RemainingCredit { get; set; }

        public long? RecurringTransactionId { get; set; }

        public long? TaxExemptionId { get; set; }

        public decimal? Balance { get; set; }

        public decimal? HomeTotalAmt { get; set; }

    }
}
