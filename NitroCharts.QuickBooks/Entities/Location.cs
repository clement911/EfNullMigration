
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class Location     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public long? ParentId { get; set; }

        public bool? Active { get; set; }

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

        
    }
}
