
using QuickBooksSharp.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class BillPayment     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public long? VendorId { get; set; }

        public decimal? TotalAmt { get; set; }

                public string PayType { get; set; }

        [Column(TypeName = "char(3)")]
        public string Currency { get; set; }

        [MaxLength(21)]
        public string DocNumber { get; set; }

        [MaxLength(4000)]
        public string PrivateNote { get; set; }

        public DateOnly? TxnDate { get; set; }

        public decimal? ExchangeRate { get; set; }

        public long? APAccountId { get; set; }

        public long? LocationId { get; set; }

                public string TransactionLocationType { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public long? CheckPayment_BankAccountId { get; set; }

                public string CheckPayment_PrintStatus { get; set; }

        public long? CreditCardPayment_CCAccountId { get; set; }

        
    }
}
