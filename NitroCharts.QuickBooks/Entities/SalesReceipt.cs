
using QuickBooksSharp.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class SalesReceipt     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public long? CustomerId { get; set; }

        [Column(TypeName = "char(3)")]
        public string Currency { get; set; }

        [MaxLength(128)]
        
        public string BillEmailAddress { get; set; }

        public DateOnly? Date { get; set; }

        #region ShipFromAddr

        [MaxLength(30)]
        public string ShipFromAddr_PostalCode { get; set; }

        [MaxLength(255)]
        public string ShipFromAddr_City { get; set; }

        [MaxLength(255)]
        public string ShipFromAddr_State { get; set; }

        [MaxLength(255)]
        public string ShipFromAddr_Country { get; set; }

        [MaxLength(500)]
        
        public string ShipFromAddr_Line1 { get; set; }

        [MaxLength(500)]
        
        public string ShipFromAddr_Line2 { get; set; }

        [MaxLength(500)]
        
        public string ShipFromAddr_Line3 { get; set; }

        [MaxLength(500)]
        
        public string ShipFromAddr_Line4 { get; set; }

        [MaxLength(500)]
        
        public string ShipFromAddr_Line5 { get; set; }

        
        
        public decimal? ShipFromAddr_Lat { get; set; }

        
        
        public decimal? ShipFromAddr_Long { get; set; }

        #endregion

        [MaxLength(31)]
        public string CustomField1 { get; set; }

        [MaxLength(31)]
        public string CustomField2 { get; set; }

        [MaxLength(31)]
        public string CustomField3 { get; set; }

        public DateOnly? ShipDate { get; set; }

        [MaxLength(100)]
        public string TrackingNum { get; set; }

                public string ClassId { get; set; }

                public string PrintStatus { get; set; }

        [MaxLength(100)]
        public string PaymentRefNum { get; set; }

                public string TxnSource { get; set; }

                public string GlobalTaxCalculation { get; set; }

                public string TransactionLocationType { get; set; }

        public bool? ApplyTaxAfterDiscount { get; set; }

        [MaxLength(21)]
        public string DocNumber { get; set; }

        [MaxLength(4000)]
        public string PrivateNote { get; set; }

        public long? DepositToAccountId { get; set; }

        [MaxLength(1024)]
        public string CustomerMemo { get; set; }

                public string EmailStatus { get; set; }

        #region Credit card payment / Charge info

        public byte? CreditCardPayment_CreditChargeInfo_CcExpiryMonth { get; set; }

        public bool? CreditCardPayment_CreditChargeInfo_ProcessPayment { get; set; }

        [MaxLength(30)]
        public string CreditCardPayment_CreditChargeInfo_PostalCode { get; set; }

        public decimal? CreditCardPayment_CreditChargeInfo_Amount { get; set; }

        [MaxLength(100)]
        
        public string CreditCardPayment_CreditChargeInfo_NameOnAcct { get; set; }

        public short? CreditCardPayment_CreditChargeInfo_CcExpiryYear { get; set; }

                public string CreditCardPayment_CreditChargeInfo_Type { get; set; }

        [MaxLength(255)]
        
        public string CreditCardPayment_CreditChargeInfo_BillAddrStreet { get; set; }

        #endregion

        #region Credit card payment / Charge response

                public string CreditCardPayment_Response_Status { get; set; }

        [MaxLength(100)]
        public string CreditCardPayment_esponse_AuthCode { get; set; }

        public DateTime? CreditCardPayment_Response_TxnAuthorizationTime { get; set; }

        [MaxLength(100)]
        public string CreditCardPayment_Response_CCTransId { get; set; }

        #endregion

                public string TaxCodeId { get; set; }

        public decimal? TotalTax { get; set; }

        public long? PaymentMethodId { get; set; }

        public decimal? ExchangeRate { get; set; }

        #region ShipToAddr

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

        #endregion

        public long? LocationId { get; set; }

        [MaxLength(100)]
        public string ShipMethod { get; set; }

        #region BillAddr

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

        #endregion

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public decimal? HomeBalance { get; set; }

                public string Delivery_Type { get; set; }

        [MaxLength(16)]
        public DateTime? Delivery_Time { get; set; }

        public long? RecurringTransactionId { get; set; }

        public decimal? TotalAmt { get; set; }

        public decimal? Balance { get; set; }

        public decimal? HomeTotalAmt { get; set; }

        public bool? FreeFormAddress { get; set; }

    }
}
