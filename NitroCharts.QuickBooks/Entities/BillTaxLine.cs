
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    
    public class BillTaxLine     {
        
        public long ConnectionId { get; set; }

        
        public long BillId { get; set; }

        public short Index { get; set; }

        public decimal? Amount { get; set; }

        public long? TaxRateId { get; set; }

        public decimal? NetAmountTaxable { get; set; }

        public bool? PercentBased { get; set; }

        public decimal? TaxInclusiveAmount { get; set; }

        public decimal? OverrideDeltaAmount { get; set; }

        public decimal? TaxPercent { get; set; }


    }
}
