
using QuickBooksSharp.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class Payment     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public decimal? TotalAmt { get; set; }

        public long? CustomerId { get; set; }

        [Column(TypeName = "char(3)")]
        public string Currency { get; set; }

        [MaxLength(4000)]
        public string PrivateNote { get; set; }

        public long? PaymentMethodId { get; set; }

        public decimal? UnappliedAmt { get; set; }

        public long? DepositToAccountId { get; set; }

        public decimal? ExchangeRate { get; set; }

                public string TxnSource { get; set; }

        public long? ARAccountId { get; set; }

        public DateOnly? TxnDate { get; set; }

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

                public string TransactionLocationType { get; set; }

        [MaxLength(100)]
        public string PaymentRefNum { get; set; }

        
    }
}
