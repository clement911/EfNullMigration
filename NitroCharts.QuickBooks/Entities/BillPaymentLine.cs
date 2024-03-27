
using System.Linq;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    
    public class BillPaymentLine     {
        
        public long ConnectionId { get; set; }

        
        public long BillPaymentId { get; set; }

        public short Index { get; set; }

        public decimal Amount { get; set; }

        public long TxnId { get; set; }

                public string TxnType { get; set; }

        public long? TxnLineId { get; set; }

        
    }
}
