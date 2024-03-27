
using QuickBooksSharp.Entities;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Wish.Core;

namespace NitroCharts.QuickBooks
{

    public class DepositLine
    {

        public long ConnectionId { get; set; }


        public long DepositId { get; set; }

        public short Index { get; set; }

        public short? LineNum { get; set; }

        public long? Id { get; set; }

        public string DetailType { get; set; }

        public decimal? Amount { get; set; }

        [MaxLength(4000)]
        public string Description { get; set; }

        public long LinkedTxnId { get; set; }

        public string LinkedTxnType { get; set; }

        public long? LinkedTxnLineId { get; set; }

        public long? AccountId { get; set; }

        public long? PaymentMethodId { get; set; }

        public string ClassId { get; set; }

        [MaxLength(100)]
        public string CheckNum { get; set; }

        public string TaxCodeId { get; set; }

        [MaxLength(8)]
        public string TaxApplicableOn { get; set; }

        public long? CustomerId { get; set; }

        public string TxnType { get; set; }

    }
}
