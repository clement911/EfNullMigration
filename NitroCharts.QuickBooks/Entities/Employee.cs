
using System;
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class Employee     {
        
        public long ConnectionId { get; set; }

        
        public long Id { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        [MaxLength(30)]
        public string PrimaryAddr_PostalCode { get; set; }

        [MaxLength(255)]
        public string PrimaryAddr_City { get; set; }

        [MaxLength(255)]
        public string PrimaryAddr_State { get; set; }

        [MaxLength(255)]
        public string PrimaryAddr_Country { get; set; }

        [MaxLength(500)]
        
        public string PrimaryAddr_Line1 { get; set; }

        [MaxLength(500)]
        
        public string PrimaryAddr_Line2 { get; set; }

        [MaxLength(500)]
        
        public string PrimaryAddr_Line3 { get; set; }

        [MaxLength(500)]
        
        public string PrimaryAddr_Line4 { get; set; }

        [MaxLength(500)]
        
        public string PrimaryAddr_Line5 { get; set; }

        
        
        public decimal? PrimaryAddr_Lat { get; set; }

        
        
        public decimal? PrimaryAddr_Long { get; set; }

        [MaxLength(128)]
        
        public string PrimaryEmailAddress { get; set; }

        [MaxLength(500)]
        public string DisplayName { get; set; }

        [MaxLength(16)]
        public string Title { get; set; }

        public bool? BillableTime { get; set; }

        [MaxLength(100)]
        public string GivenName { get; set; }

        public DateOnly? BirthDate { get; set; }

        [MaxLength(100)]
        public string MiddleName { get; set; }

        [MaxLength(100)]
        
        public string SSN { get; set; }

        [MaxLength(32)]
        
        public string PrimaryPhone { get; set; }

        public bool? Active { get; set; }

        public DateOnly? ReleasedDate { get; set; }

        [MaxLength(20)]
        
        public string Mobile { get; set; }

                public string Gender { get; set; }

        public DateOnly? HiredDate { get; set; }

        public decimal? BillRate { get; set; }

        public bool? Organization { get; set; }

        [MaxLength(16)]
        public string Suffix { get; set; }

        [MaxLength(100)]
        public string FamilyName { get; set; }

        [MaxLength(100)]
        public string PrintOnCheckName { get; set; }

        [MaxLength(100)]
        
        public string EmployeeNumber { get; set; }

        [MaxLength(100)]
        public string V4IDPseudonym { get; set; }

        public decimal? CostRate { get; set; }

    }
}
