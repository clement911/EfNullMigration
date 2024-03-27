
using System;
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class Transfer     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public decimal? Amount { get; set; }

        public long? ToAccountId { get; set; }

        public long? FromAccountId { get; set; }

        [MaxLength(4000)]
        public string PrivateNote { get; set; }

        public DateOnly? TxnDate { get; set; }

                public string TransactionLocationType { get; set; }

        public long? RecurringTransactionId { get; set; }

    }
}
