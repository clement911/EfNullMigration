
using System;
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class Term
    {

        public long ConnectionId { get; set; }


        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        [MaxLength(31)]
        public string Name { get; set; }

        public decimal? DiscountPercent { get; set; }

        public short? DiscountDays { get; set; }

        public bool? Active { get; set; }

        public string Type { get; set; }

        public byte? DayOfMonthDue { get; set; }

        public byte? DiscountDayOfMonth { get; set; }

        public short? DueNextMonthDays { get; set; }

        public short? DueDays { get; set; }

    }
}
