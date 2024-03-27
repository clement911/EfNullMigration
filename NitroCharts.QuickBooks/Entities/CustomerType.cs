
using System;
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class CustomerType     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public bool? Active { get; set; }

    }
}
