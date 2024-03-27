
using QuickBooksSharp.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class PurchaseOrder     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public long? APAccountId { get; set; }

        public long? VendorId { get; set; }

        [Column(TypeName = "char(3)")]
        public string Currency { get; set; }

        public DateOnly? Date { get; set; }

        [MaxLength(31)]
        public string CustomField1 { get; set; }

        [MaxLength(31)]
        public string CustomField2 { get; set; }

        [MaxLength(31)]
        public string CustomField3 { get; set; }

        [MaxLength(100)]
        public string POEmail { get; set; }

                public string ClassId { get; set; }

        public long? SalesTermId { get; set; }

                public string GlobalTaxCalculation { get; set; }

        [MaxLength(4000)]
        public string Memo { get; set; }

                public string POStatus { get; set; }

                public string TransactionLocationType { get; set; }

        public DateOnly? DueDate { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        [MaxLength(21)]
        public string DocNumber { get; set; }

        [MaxLength(4000)]
        public string PrivateNote { get; set; }

        [MaxLength(64)]
        public string ShipMethod { get; set; }

        #region TxnTaxDetail

                public string TaxCodeId { get; set; }

        public decimal? TotalTax { get; set; }

        #endregion

        public long? ShipToCustomerId { get; set; }

        public decimal? ExchangeRate { get; set; }

        #region ShipAddr

        [MaxLength(30)]
        public string ShipAddr_PostalCode { get; set; }

        [MaxLength(255)]
        public string ShipAddr_City { get; set; }

        [MaxLength(255)]
        public string ShipAddr_State { get; set; }

        [MaxLength(255)]
        public string ShipAddr_Country { get; set; }

        [MaxLength(500)]
        
        public string ShipAddr_Line1 { get; set; }

        [MaxLength(500)]
        
        public string ShipAddr_Line2 { get; set; }

        [MaxLength(500)]
        
        public string ShipAddr_Line3 { get; set; }

        [MaxLength(500)]
        
        public string ShipAddr_Line4 { get; set; }

        [MaxLength(500)]
        
        public string ShipAddr_Line5 { get; set; }

        
        
        public decimal? ShipAddr_Lat { get; set; }

        
        
        public decimal? ShipAddr_Long { get; set; }

        #endregion

        #region VendorAddr

        [MaxLength(30)]
        public string VendorAddr_PostalCode { get; set; }

        [MaxLength(255)]
        public string VendorAddr_City { get; set; }

        [MaxLength(255)]
        public string VendorAddr_State { get; set; }

        [MaxLength(255)]
        public string VendorAddr_Country { get; set; }

        [MaxLength(500)]
        
        public string VendorAddr_Line1 { get; set; }

        [MaxLength(500)]
        
        public string VendorAddr_Line2 { get; set; }

        [MaxLength(500)]
        
        public string VendorAddr_Line3 { get; set; }

        [MaxLength(500)]
        
        public string VendorAddr_Line4 { get; set; }

        [MaxLength(500)]
        
        public string VendorAddr_Line5 { get; set; }

        
        
        public decimal? VendorAddr_Lat { get; set; }

        
        
        public decimal? VendorAddr_Long { get; set; }

        #endregion

                public string EmailStatus { get; set; }

        public decimal? TotalAmt { get; set; }

        public long? RecurringTransactionId { get; set; }

    }
}
