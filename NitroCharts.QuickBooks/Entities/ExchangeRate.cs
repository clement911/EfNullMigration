
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class ExchangeRate 
    {
        
        public long ConnectionId { get; set; }

        [NotMapped]
        public long Id 
        {
            get { throw new Exception(); }
            set { throw new Exception(); }
        }

                public string SourceCurrencyCode { get; set; }

                public string TargetCurrencyCode { get; set; }

        public DateOnly AsOfDate { get; set; }

        public decimal Rate { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

    }
}
