
using System;
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class TaxRate     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public decimal? RateValue { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public long? AgencyId { get; set; }

                public string SpecialTaxType { get; set; }

        [MaxLength(1024)]
        public string EffectiveTaxRatesJSON { get; set; }

                public string DisplayType { get; set; }

        public long? TaxReturnLineId { get; set; }

        public bool? Active { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }



    }
}
