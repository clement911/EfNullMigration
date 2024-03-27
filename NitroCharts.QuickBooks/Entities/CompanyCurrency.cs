
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class CompanyCurrency     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        [Column(TypeName = "char(3)")]
        public string Code { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public bool? Active { get; set; }

    
    }
}
