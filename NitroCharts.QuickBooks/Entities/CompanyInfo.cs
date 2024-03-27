
using System;
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class CompanyInfo     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        [MaxLength(1024)]
        public string CompanyName { get; set; }

        [MaxLength(100)]
        public string SupportedLanguages { get; set; }

        [MaxLength(16)]
        public string Country { get; set; }

        [MaxLength(128)]
        public string EmailAddress { get; set; }

        [MaxLength(9)]
        public string FiscalYearStartMonth { get; set; }

        [MaxLength(1024)]
        public string LegalName { get; set; }

        public DateOnly? CompanyStartDate { get; set; }

        [MaxLength(4000)]
        public string NameValuesJSON { get; set; }


    }
}
