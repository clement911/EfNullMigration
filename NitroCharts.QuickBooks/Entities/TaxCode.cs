
using System;
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class TaxCode 
    {
        
        public long ConnectionId { get; set; }

        /// <summary>
        /// Built-in tax code ID can be non-numeric, e.g. TAX or NON
        /// </summary>
                public string Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public bool? Active { get; set; }

        public bool? Hidden { get; set; }

        public bool? Taxable { get; set; }

        public bool? TaxGroup { get; set; }

                public string TaxCodeConfigType { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

    }
}
