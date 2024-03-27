using Microsoft.Extensions.Logging;

using System.ComponentModel.DataAnnotations;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    
    public class PurchaseLine     {
        
        public long ConnectionId { get; set; }

        
        public long PurchaseId { get; set; }

        public short Index { get; set; }

        public short? LineNum { get; set; }

        public long? Id { get; set; }

                public string DetailType { get; set; }

        public decimal? Amount { get; set; }

        [MaxLength(4000)]
        public string Description { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? TaxInclusiveAmt { get; set; }

        public long? ItemId { get; set; }

        public long? CustomerId { get; set; }

        public long? PriceLevelId { get; set; }

                public string ClassId { get; set; }

        public long? AccountId { get; set; }

                public string TaxCodeId { get; set; }

        #region MarkupInfo
        public long? MarkupInfo_PriceLevelId { get; set; }

        public decimal? MarkupInfo_Percent { get; set; }

        public long? MarkupInfo_MarkUpIncomeAccountId { get; set; }
        #endregion

                public string BillableStatus { get; set; }

        public decimal? Qty { get; set; }

        public decimal? UnitPrice { get; set; }

    }
}
