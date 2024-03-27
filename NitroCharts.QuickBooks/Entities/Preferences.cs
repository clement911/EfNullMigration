
using QuickBooksSharp.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class Preferences 
    {
        
        public long ConnectionId { get; set; }

        [NotMapped]
        public long Id
        {
            get { throw new Exception(); }
            set { throw new Exception(); }
        }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdatedTime { get; set; }

        [MaxLength(1000)]
        public string EmailMessagesPrefs_InvoiceMessage_Message { get; set; }

        [MaxLength(256)]
        public string EmailMessagesPrefs_InvoiceMessage_Subject { get; set; }

        [MaxLength(1000)]
        public string EmailMessagesPrefs_EstimateMessage_Message { get; set; }

        [MaxLength(256)]
        public string EmailMessagesPrefs_EstimateMessage_Subject { get; set; }

        [MaxLength(1000)]
        public string EmailMessagesPrefs_SalesReceiptMessage_Message { get; set; }

        [MaxLength(256)]
        public string EmailMessagesPrefs_SalesReceiptMessage_Subject { get; set; }

        [MaxLength(1000)]
        public string EmailMessagesPrefs_StatementMessage_Message { get; set; }

        [MaxLength(256)]
        public string EmailMessagesPrefs_StatementMessage_Subject { get; set; }

        public bool? ProductAndServicesPrefs_QuantityWithPriceAndRate { get; set; }

        public bool? ProductAndServicesPrefs_QuantityOnHand { get; set; }

        public bool? ProductAndServicesPrefs_ForSales { get; set; }

        public bool? ProductAndServicesPrefs_ForPurchase { get; set; }

                public string ReportPrefs_ReportBasis { get; set; }

        public bool? ReportPrefs_CalcAgingReportFromTxnDate { get; set; }

        [MaxLength(9)]
        public string AccountingInfoPrefs_FirstMonthOfFiscalYear { get; set; }

        public bool? AccountingInfoPrefs_UseAccountNumbers { get; set; }

                public string AccountingInfoPrefs_TaxYearMonth { get; set; }

        public bool? AccountingInfoPrefs_ClassTrackingPerTxn { get; set; }

        public bool? AccountingInfoPrefs_ClassTrackingPerTxnLine { get; set; }

        public bool? AccountingInfoPrefs_TrackLocations { get; set; }

                public string AccountingInfoPrefs_TaxForm { get; set; }

        [MaxLength(16)]
        public string AccountingInfoPrefs_CustomerTerminology { get; set; }

        public DateOnly? AccountingInfoPrefs_BookCloseDate { get; set; }

        [MaxLength(16)]
        public string AccountingInfoPrefs_DepartmentTerminology { get; set; }


        [MaxLength(100)]
        public string SalesFormsPrefs_SalesEmailCc { get; set; }

        [MaxLength(100)]
        public string SalesFormsPrefs_SalesEmailBcc { get; set; }

        public bool? SalesFormsPrefs_UsingProgressInvoicing { get; set; }

        public bool? SalesFormsPrefs_AllowServiceDate { get; set; }

        [MaxLength(512)]
        public string SalesFormsPrefs_EstimateMessage { get; set; }

        public bool? SalesFormsPrefs_EmailCopyToCompany { get; set; }

        [MaxLength(512)]
        public string SalesFormsPrefs_DefaultCustomerMessage { get; set; }

        public bool? SalesFormsPrefs_AllowShipping { get; set; }

        [MaxLength(16)]
        public string SalesFormsPrefs_DefaultDiscountAccount { get; set; }

        public bool? SalesFormsPrefs_IPNSupportEnabled { get; set; }

        public bool? SalesFormsPrefs_ETransactionPaymentEnabled { get; set; }

        public long? SalesFormsPrefs_DefaultTermsId { get; set; }

        public bool? SalesFormsPrefs_AllowDeposit { get; set; }

        public bool? SalesFormsPrefs_UsingPriceLevels { get; set; }

        [MaxLength(16)]
        public string SalesFormsPrefs_DefaultShippingAccount { get; set; }

        public bool? SalesFormsPrefs_ETransactionAttachPDF { get; set; }

        public bool? SalesFormsPrefs_CustomTxnNumbers { get; set; }

        [MaxLength(13)]
        public string SalesFormsPrefs_ETransactionEnabledStatus { get; set; }

        public bool? SalesFormsPrefs_AllowEstimates { get; set; }

        public bool? SalesFormsPrefs_AllowDiscount { get; set; }

        public bool? SalesFormsPrefs_AutoApplyCredit { get; set; }

        public bool? SalesFormsPrefs_AutoApplyPayments { get; set; }

        [MaxLength(4000)]
        public string SalesFormsPrefs_CustomFieldJSON { get; set; }

        public long? VendorAndPurchasesPrefs_DefaultMarkupAccountId { get; set; }

        public bool? VendorAndPurchasesPrefs_TrackingByCustomer { get; set; }

        public long? VendorAndPurchasesPrefs_DefaultTermsId { get; set; }

        public bool? VendorAndPurchasesPrefs_BillableExpenseTracking { get; set; }

        public decimal? VendorAndPurchasesPrefs_DefaultMarkup { get; set; }

        public bool? VendorAndPurchasesPrefs_TPAREnabled { get; set; }

        [MaxLength(4000)]
        public string VendorAndPurchasesPrefs_POCustomFieldJSON { get; set; }

        public bool? TaxPrefs_PartnerTaxEnabled { get; set; }

                public string TaxPrefs_TaxGroupCodeId { get; set; }

        public bool? TaxPrefs_UsingSalesTax { get; set; }

        [MaxLength(4000)]
        public string OtherPrefs_NameValuesJSON { get; set; }

        [MaxLength(9)]
        public string TimeTrackingPrefs_WorkWeekStartDate { get; set; }

        public bool? TimeTrackingPrefs_MarkTimeEntriesBillable { get; set; }

        public bool? TimeTrackingPrefs_ShowBillRateToAll { get; set; }

        public bool? TimeTrackingPrefs_BillCustomers { get; set; }

        public bool? TimeTrackingPrefs_UseServices { get; set; }

        public bool? CurrencyPrefs_MultiCurrencyEnabled { get; set; }

        [Column(TypeName = "char(3)")]
        public string CurrencyPrefs_HomeCurrency { get; set; }

    }
}
