
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class Vendor     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

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

        [MaxLength(100)]
        
        public string PrimaryEmailAddr { get; set; }

        [MaxLength(500)]
        
        public string DisplayName { get; set; }

        public long? APAccountId { get; set; }

        public long? TermId { get; set; }

        [MaxLength(15)]
        
        public string GSTIN { get; set; }

        [MaxLength(30)]
        
        public string Fax { get; set; }

        [MaxLength(16)]
        
        public string BusinessNumber { get; set; }

        [Column(TypeName = "char(3)")]
        public string Currency { get; set; }

        public bool? HasTPAR { get; set; }

        [MaxLength(7)]
        public string TaxReportingBasis { get; set; }

        [MaxLength(30)]
        
        public string Mobile { get; set; }

        [MaxLength(32)]
        
        public string PrimaryPhone { get; set; }

        public bool? Active { get; set; }

        [MaxLength(30)]
        
        public string AlternatePhone { get; set; }

        public bool? Vendor1099 { get; set; }

        public decimal? BillRate { get; set; }

        [MaxLength(100)]
        
        public string WebAddr { get; set; }

        [MaxLength(100)]
        
        public string CompanyName { get; set; }

        [MaxLength(100)]
        public string VendorPaymentBankDetail_BankAccountName { get; set; }

        [MaxLength(32)]
        
        public string VendorPaymentBankDetail_BankBranchIdentifier { get; set; }

        [MaxLength(32)]
        
        public string VendorPaymentBankDetail_BankAccountNumber { get; set; }

        [MaxLength(18)]
        
        public string VendorPaymentBankDetail_StatementText { get; set; }

        [MaxLength(20)]
        
        public string TaxIdentifier { get; set; }

        [MaxLength(100)]
        
        public string AcctNum { get; set; }

                public string GSTRegistrationType { get; set; }

        [MaxLength(110)]
        
        public string PrintOnCheckName { get; set; }

        [MaxLength(30)]
        public string BillAddr_PostalCode { get; set; }

        [MaxLength(255)]
        public string BillAddr_City { get; set; }

        [MaxLength(255)]
        public string BillAddr_State { get; set; }

        [MaxLength(255)]
        public string BillAddr_Country { get; set; }

        [MaxLength(500)]
        
        public string BillAddr_Line1 { get; set; }

        [MaxLength(500)]
        
        public string BillAddr_Line2 { get; set; }

        [MaxLength(500)]
        
        public string BillAddr_Line3 { get; set; }

        [MaxLength(500)]
        
        public string BillAddr_Line4 { get; set; }

        [MaxLength(500)]
        
        public string BillAddr_Line5 { get; set; }

        
        
        public decimal? BillAddr_Lat { get; set; }

        
        
        public decimal? BillAddr_Long { get; set; }

        public decimal? Balance { get; set; }

        public decimal? CostRate { get; set; }

       
    }
}
