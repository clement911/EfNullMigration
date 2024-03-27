using Microsoft.Extensions.Logging;

using QuickBooksSharp.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    
    public class JournalEntryLine     {
        
        public long ConnectionId { get; set; }

        
        public long JournalEntryId { get; set; }

        public short Index { get; set; }

        public short? LineNum { get; set; }

        public long? Id { get; set; }

                public string DetailType { get; set; }

        public decimal? Amount { get; set; }

        [MaxLength(4000)]
        public string Description { get; set; }

                public string TaxCodeId { get; set; }

        public DateOnly? ServiceDate { get; set; }

        public long? JournalCodeId { get; set; }

                public string PostingType { get; set; }

        public long? AccountId { get; set; }

                public string TaxApplicableOn { get; set; }

        public long? VendorId { get; set; }

        public long? CustomerId { get; set; }

        public long? EmployeeId { get; set; }

        public decimal? TaxInclusiveAmt { get; set; }

                public string ClassId { get; set; }

        public long? LocationId { get; set; }

                public string BillableStatus { get; set; }

        public decimal? TaxAmount { get; set; }

      
    }
}
