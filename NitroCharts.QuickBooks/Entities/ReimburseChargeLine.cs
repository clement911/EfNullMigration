
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    
    public class ReimburseChargeLine     {
        
        public long ConnectionId { get; set; }

        
        public long ReimburseChargeId { get; set; }

        public short Index { get; set; }

        public short? LineNum { get; set; }

        public long? Id { get; set; }

        //Several fields below appear to be undocumented at the time of writing

        #region MarkupInfo
        public long? MarkupInfo_PriceLevelId { get; set; }

        public decimal? MarkupInfo_Percent { get; set; }

        public long? MarkupInfo_MarkUpIncomeAccountId { get; set; }
        #endregion

        public long? ItemId { get; set; }

                public string ClassId { get; set; }

                public string TaxCodeId { get; set; }

        public decimal? Qty { get; set; }

        public decimal? UnitPrice { get; set; }

    }
}
