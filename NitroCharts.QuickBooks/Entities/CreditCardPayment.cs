
using System;
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class CreditCardPayment     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public long? CreditCardAccountId { get; set; }

        public decimal? Amount { get; set; }

        public long? BankAccountId { get; set; }

        [MaxLength(4000)]
        public string PrivateNote { get; set; }

        public long? VendorId { get; set; }

        public DateOnly? TxnDate { get; set; }

        [MaxLength(4000)]
        public string Memo { get; set; }

                public string PrintStatus { get; set; }

        [MaxLength(32)]
        
        public string CheckNum { get; set; }


    }
}
