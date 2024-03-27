
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class Item     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

                public string ItemCategoryType { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public DateOnly? InvStartDate { get; set; }

        [MaxLength(12)]
        public string Type { get; set; }

        public decimal? QtyOnHand { get; set; }

        public long? AssetAccountId { get; set; }

        [MaxLength(100)]
        public string Sku { get; set; }

        public bool? SalesTaxIncluded { get; set; }

        public bool? TrackQtyOnHand { get; set; }

                public string SalesTaxCodeId { get; set; }

                public string ClassId { get; set; }

        public bool? PurchaseTaxIncluded { get; set; }

        [MaxLength(4000)]
        public string Description { get; set; }

        public decimal? AbatementRate { get; set; }

        public decimal? ReverseChargeRate { get; set; }

        public bool? SubItem { get; set; }

        public bool? Taxable { get; set; }

        [MaxLength(25)]
        public string UQCDisplayText { get; set; }

        public decimal? ReorderPoint { get; set; }

        [MaxLength(1000)]
        public string PurchaseDesc { get; set; }

        public long? PrefVendorId { get; set; }

        public bool? Active { get; set; }

        [MaxLength(3)]
        public string UQCId { get; set; }

                public string PurchaseTaxCodeId { get; set; }

                public string ServiceType { get; set; }

        public decimal? PurchaseCost { get; set; }

        public long? ParentId { get; set; }

        public decimal? UnitPrice { get; set; }

        [MaxLength(100)]
        public string Level1 { get; set; }

        [MaxLength(100)]
        public string Level2 { get; set; }

        [MaxLength(100)]
        public string Level3 { get; set; }

        [MaxLength(100)]
        public string Level4 { get; set; }

        [MaxLength(100)]
        public string Level5 { get; set; }

        public int? Level { get; set; }

        public long? IncomeAccountId { get; set; }

        public long? ExpenseAccountId { get; set; }

                public string TaxClassificationId { get; set; }

        public bool? PrintGroupedItems { get; set; }

    }
}
