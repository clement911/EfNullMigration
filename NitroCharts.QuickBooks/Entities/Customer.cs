
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class Customer     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        [MaxLength(500)]
        
        public string DisplayName { get; set; }

        [MaxLength(16)]
        public string Title { get; set; }

        [MaxLength(100)]
        
        public string GivenName { get; set; }

        [MaxLength(100)]
        
        public string MiddleName { get; set; }

        [MaxLength(16)]
        public string Suffix { get; set; }

        [MaxLength(100)]
        
        public string FamilyName { get; set; }

        [MaxLength(128)]
        
        public string PrimaryEmailAddress { get; set; }

        [MaxLength(16)]
        public string ResaleNum { get; set; }

        [MaxLength(16)]
        
        public string SecondaryTaxIdentifier { get; set; }

        public long? ARAccountId { get; set; }

                public string DefaultTaxCodeId { get; set; }

                public string PreferredDeliveryMethod { get; set; }

        [MaxLength(15)]
        
        public string GSTIN { get; set; }

        public long? SalesTermId { get; set; }

        public long? CustomerTypeId { get; set; }

        [MaxLength(30)]
        
        public string FaxNumber { get; set; }

        [MaxLength(16)]
        
        public string BusinessNumber { get; set; }

        public bool? BillWithParent { get; set; }

        [Column(TypeName = "char(3)")]
        public string Currency { get; set; }

        [MaxLength(30)]
        
        public string MobileNumber { get; set; }

        public bool? Job { get; set; }

        [MaxLength(32)]
        
        public string PrimaryPhoneNumber { get; set; }

        public DateOnly? OpenBalanceDate { get; set; }

        public bool? Taxable { get; set; }

        [MaxLength(30)]
        
        public string AlternatePhoneNumber { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        public long? ParentId { get; set; }

        [MaxLength(2000)]
        public string Notes { get; set; }

        [MaxLength(1000)]
        
        public string WebAddressUrl { get; set; }

        public bool? Active { get; set; }

        [MaxLength(30)]
        public string ShippingAddress_PostalCode { get; set; }

        [MaxLength(255)]
        public string ShippingAddress_City { get; set; }

        [MaxLength(255)]
        public string ShippingAddress_Country { get; set; }

        [MaxLength(500)]
        
        public string ShippingAddress_Line1 { get; set; }

        [MaxLength(500)]
        
        public string ShippingAddress_Line2 { get; set; }

        [MaxLength(500)]
        
        public string ShippingAddress_Line3 { get; set; }

        [MaxLength(500)]
        
        public string ShippingAddress_Line4 { get; set; }

        [MaxLength(500)]
        
        public string ShippingAddress_Line5 { get; set; }

        
        
        public decimal? ShippingAddress_Lat { get; set; }

        
        
        public decimal? ShippingAddress_Long { get; set; }

        [MaxLength(255)]
        public string ShippingAddress_State { get; set; }

        [MaxLength(30)]
        public string BillingAddress_PostalCode { get; set; }

        [MaxLength(255)]
        public string BillingAddress_City { get; set; }

        [MaxLength(255)]
        public string BillingAddress_Country { get; set; }

        [MaxLength(500)]
        
        public string BillingAddress_Line1 { get; set; }

        [MaxLength(500)]
        
        public string BillingAddress_Line2 { get; set; }

        [MaxLength(500)]
        
        public string BillingAddress_Line3 { get; set; }

        [MaxLength(500)]
        
        public string BillingAddress_Line4 { get; set; }

        [MaxLength(500)]
        
        public string BillingAddress_Line5 { get; set; }

        
        
        public decimal? BillingAddress_Lat { get; set; }

        
        
        public decimal? BillingAddress_Long { get; set; }

        [MaxLength(255)]
        public string BillingAddress_State { get; set; }

        public long? PaymentMethodId { get; set; }

        public bool? IsProject { get; set; }

        [MaxLength(100)]
        
        public string CompanyName { get; set; }

        [MaxLength(32)]
        
        public string PrimaryTaxIdentifier { get; set; }

                public string GSTRegistrationType { get; set; }

        [MaxLength(110)]
        
        public string PrintOnCheckName { get; set; }

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

        public byte? Level { get; set; }

        public byte? TaxExemptionReasonId { get; set; }

    }
}
