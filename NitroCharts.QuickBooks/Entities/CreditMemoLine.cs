
using QuickBooksSharp.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    
    public class CreditMemoLine     {
        
        public long ConnectionId { get; set; }

        
        public long CreditMemoId { get; set; }

        public short Index { get; set; }

        public short? LineNum { get; set; }

        public long? Id { get; set; }

                public string DetailType { get; set; }

        public decimal? Amount { get; set; }

        [MaxLength(4000)]
        public string Description { get; set; }

        public decimal? TaxInclusiveAmt { get; set; }

        public decimal? DiscountAmt { get; set; }

        public long? ItemId { get; set; }

                public string SpecialItemId { get; set; }

                public string ClassId { get; set; }

                public string TaxCodeId { get; set; }

        #region MarkupInfo
        public long? MarkupInfo_PriceLevelId { get; set; }

        public decimal? MarkupInfo_Percent { get; set; }

        public long? MarkupInfo_MarkUpIncomeAccountId { get; set; }
        #endregion

        public long? ItemAccountId { get; set; }

        public DateOnly? ServiceDate { get; set; }

        public decimal? DiscountRate { get; set; }

        public decimal? Qty { get; set; }

        public decimal? UnitPrice { get; set; }

                public string TaxClassificationId { get; set; }

        public long? DiscountAccountId { get; set; }

        public bool? PercentBased { get; set; }

        public decimal? DiscountPercent { get; set; }

        public long? GroupLineId { get; set; }

        public decimal? GroupQuantity { get; set; }

        public long? GroupItemId { get; set; }

    }
}
