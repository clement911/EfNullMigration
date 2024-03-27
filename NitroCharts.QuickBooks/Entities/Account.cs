
using QuickBooksSharp.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class Account     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [MaxLength(20)]
        public string AcctNum { get; set; }

        [Column(TypeName = "char(3)")]
        public string Currency { get; set; }

        public long? ParentAccountId { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public bool? Active { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public bool? SubAccount { get; set; }

                public string Classification { get; set; }

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

        [MaxLength(19)]
        public string TxnLocationType { get; set; }

        [MaxLength(21)]
        public string AccountType { get; set; }

        public decimal? CurrentBalanceWithSubAccounts { get; set; }

        [MaxLength(100)]
        public string AccountAlias { get; set; }

                public string TaxCodeId { get; set; }

                public string AccountSubType { get; set; }

        public decimal? CurrentBalance { get; set; }

    }
}
