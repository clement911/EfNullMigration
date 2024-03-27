
using System;
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class TimeActivity     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

                public string NameOf { get; set; }

        public DateOnly? TxnDate { get; set; }

        public long? EmployeeId { get; set; }

        public long? VendorId { get; set; }

        public short? Hours { get; set; }

        public byte? Minutes { get; set; }

        public DateTimeOffset? StartTime { get; set; }

        public decimal? HourlyRate { get; set; }

        public short? BreakHours { get; set; }

        public byte? BreakMinutes { get; set; }

        public DateTimeOffset? EndTime { get; set; }

        [MaxLength(4000)]
        public string Description { get; set; }

        public long? ItemId { get; set; }

                public string ClassId { get; set; }

        public long? LocationId { get; set; }

                public string PayrollItemId { get; set; }

                public string BillableStatus { get; set; }

        public bool? Taxable { get; set; }

        public long? CustomerId { get; set; }

        public decimal? CostRate { get; set; }

    }
}
