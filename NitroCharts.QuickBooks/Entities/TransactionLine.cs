
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    /// <summary>
    /// In cash-basis, a single bill/invoice can generate a separate set of lines for each payment
    /// As a result, a single AR/AP transaction can have lines with different dates (in cash basis only)
    /// </summary>
    public class TransactionLine
    {

        public long ConnectionId { get; set; }

        [DateOnly]
        public DateTime Date { get; set; }


        public long TransactionId { get; set; }

        public long Id { get; set; }

        public DateTime PersistedAt { get; set; }

        public bool IsCash { get; set; }

        public string Type { get; set; }//there was a case where this was null for a ExchangeGainOrLoss line

        public string SubType { get; set; }

        public DateTime CreateTime { get; set; }

        [MaxLength(100)]
        public string CreatedBy { get; set; }

        [MaxLength(21)]
        public string DocNumber { get; internal set; }

        public decimal? ExchangeRate { get; set; }

        [Column(TypeName = "char(3)")]
        [Required]
        public string Currency { get; set; }

        public DateTime? DueDate { get; set; }

        public decimal? OpenBalance { get; set; }

        public decimal? ForeignOpenBalance { get; set; }

        public string AdjustmentStatus { get; set; }

        public string ARPaidStatus { get; set; }

        public string APPaidStatus { get; set; }

        public string ClearedStatus { get; set; }

        public string OnlineBankingStatus { get; set; }

        public string CheckPrintStatus { get; set; }

        public long? AccountId { get; set; }

        public long? DistributionAccountId { get; set; }

        //If amount > 0 then it's a debit, otherwise it's a credit
        public decimal SignedDebitAmount { get; set; }

        public decimal ForeignEntryAmount { get; set; }

        public string TaxableStatus { get; set; }

        public decimal? HomeAmount { get; set; }

        public decimal? ForeignAmount { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? ForeignTaxAmount { get; set; }

        public decimal? TaxableAmount { get; set; }

        public decimal? ForeignTaxableAmount { get; set; }

        public string ClassId { get; set; }

        public long? LocationId { get; set; }

        public DateTime LastUpdatedTime { get; set; }

        [MaxLength(100)]
        public string LastUpdatedBy { get; set; }

        [MaxLength(4000)]
        public string Description { get; set; }

        public long? PaymentMethodId { get; set; }

        public long? VendorId { get; set; }

        public long? ItemId { get; set; }

        public long? CustomerId { get; set; }

        public long? EmployeeId { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? Rate { get; set; }

        public string TaxCodeId { get; set; }
    }
}
