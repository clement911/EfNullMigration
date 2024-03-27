using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    /// <summary>
    /// Run the following command to trigger the bug:
    /// 
    /// dotnet ef migrations -p .\NitroCharts.QuickBooks add MyQuickBooksMg -c QuickBooksPublicContext
    /// </summary>
    public class QuickBooksPublicContextFactory : IDesignTimeDbContextFactory<QuickBooksPublicContext>
    {
        public QuickBooksPublicContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<QuickBooksPublicContext>();

            optionsBuilder.UseSqlServer("SOME_CONNECTION_STRING",
                                     b => b.MigrationsHistoryTable("_Migrations", QuickBooksPublicContext.SCHEMA_QUICKBOOKS));
            return new QuickBooksPublicContext(optionsBuilder.Options);
        }
    }

    public class QuickBooksPublicContext : DbContext
    {
        public const string SCHEMA_QUICKBOOKS = "quickbooks";

        public QuickBooksPublicContext(DbContextOptions<QuickBooksPublicContext> options)
                                          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema(SCHEMA_QUICKBOOKS);

            builder.Entity<Account>().HasKey(i => new { i.ConnectionId, i.Id });

            builder.Entity<Bill>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<BillLine>().HasKey(i => new { i.ConnectionId, i.BillId, i.Index });
            builder.Entity<BillTaxLine>().HasKey(i => new { i.ConnectionId, i.BillId, i.Index });

            builder.Entity<BillPayment>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<BillPaymentLine>().HasKey(i => new { i.ConnectionId, i.BillPaymentId, i.Index });

            builder.Entity<Budget>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<BudgetLine>().HasKey(i => new { i.ConnectionId, i.BudgetId, i.Index });

            builder.Entity<Class>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<CompanyCurrency>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<CompanyInfo>().HasKey(i => new { i.ConnectionId, i.Id });

            builder.Entity<CreditMemo>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<CreditMemoLine>().HasKey(i => new { i.ConnectionId, i.CreditMemoId, i.Index });
            builder.Entity<CreditMemoTaxLine>().HasKey(i => new { i.ConnectionId, i.CreditMemoId, i.Index });

            builder.Entity<CreditCardPayment>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<Customer>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<CustomerType>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<Location>().HasKey(i => new { i.ConnectionId, i.Id });

            builder.Entity<Deposit>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<DepositLine>().HasKey(i => new { i.ConnectionId, i.DepositId, i.Index });
            builder.Entity<DepositTaxLine>().HasKey(i => new { i.ConnectionId, i.DepositId, i.Index });

            builder.Entity<Employee>().HasKey(i => new { i.ConnectionId, i.Id });

            builder.Entity<Estimate>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<EstimateLine>().HasKey(i => new { i.ConnectionId, i.EstimateId, i.Index });
            builder.Entity<EstimateTaxLine>().HasKey(i => new { i.ConnectionId, i.EstimateId, i.Index });

            builder.Entity<ExchangeRate>().HasKey(i => new { i.ConnectionId, i.SourceCurrencyCode, i.TargetCurrencyCode, i.AsOfDate });

            builder.Entity<Invoice>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<InvoiceLine>().HasKey(i => new { i.ConnectionId, i.InvoiceId, i.Index });
            builder.Entity<InvoiceTaxLine>().HasKey(i => new { i.ConnectionId, i.InvoiceId, i.Index });

            builder.Entity<Item>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<BundleItemLine>().HasKey(i => new { i.ConnectionId, i.BundleItemId, i.Index });

            builder.Entity<JournalEntry>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<JournalEntryLine>().HasKey(i => new { i.ConnectionId, i.JournalEntryId, i.Index });
            builder.Entity<JournalEntryTaxLine>().HasKey(i => new { i.ConnectionId, i.JournalEntryId, i.Index });

            builder.Entity<Payment>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<PaymentLine>().HasKey(i => new { i.ConnectionId, i.PaymentId, i.Index });

            builder.Entity<PaymentMethod>().HasKey(i => new { i.ConnectionId, i.Id });

            builder.Entity<Preferences>().HasKey(i => new { i.ConnectionId });

            builder.Entity<Purchase>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<PurchaseLine>().HasKey(i => new { i.ConnectionId, i.PurchaseId, i.Index });
            builder.Entity<PurchaseTaxLine>().HasKey(i => new { i.ConnectionId, i.PurchaseId, i.Index });

            builder.Entity<PurchaseOrder>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<PurchaseOrderLine>().HasKey(i => new { i.ConnectionId, i.PurchaseOrderId, i.Index });
            builder.Entity<PurchaseOrderTaxLine>().HasKey(i => new { i.ConnectionId, i.PurchaseOrderId, i.Index });

            builder.Entity<RefundReceipt>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<RefundReceiptLine>().HasKey(i => new { i.ConnectionId, i.RefundReceiptId, i.Index });
            builder.Entity<RefundReceiptTaxLine>().HasKey(i => new { i.ConnectionId, i.RefundReceiptId, i.Index });

            builder.Entity<ReimburseCharge>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<ReimburseChargeLine>().HasKey(i => new { i.ConnectionId, i.ReimburseChargeId, i.Index });

            builder.Entity<SalesReceipt>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<SalesReceiptLine>().HasKey(i => new { i.ConnectionId, i.SalesReceiptId, i.Index });
            builder.Entity<SalesReceiptTaxLine>().HasKey(i => new { i.ConnectionId, i.SalesReceiptId, i.Index });

            builder.Entity<TaxAgency>().HasKey(i => new { i.ConnectionId, i.Id });

            builder.Entity<TaxClassification>().HasKey(i => new { i.ConnectionId, i.Id });

            builder.Entity<TaxCode>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<TaxCodeRatePurchase>().HasKey(i => new { i.ConnectionId, i.TaxCodeId, i.Index });
            builder.Entity<TaxCodeRateSales>().HasKey(i => new { i.ConnectionId, i.TaxCodeId, i.Index });

            builder.Entity<TaxPayment>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<TaxRate>().HasKey(i => new { i.ConnectionId, i.Id });

            builder.Entity<Term>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<TimeActivity>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<Transfer>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<Vendor>().HasKey(i => new { i.ConnectionId, i.Id });

            builder.Entity<VendorCredit>().HasKey(i => new { i.ConnectionId, i.Id });
            builder.Entity<VendorCreditLine>().HasKey(i => new { i.ConnectionId, i.VendorCreditId, i.Index });

            builder.Entity<TransactionLine>().HasKey(i => new { i.ConnectionId, i.Date, i.TransactionId, i.Id });
            builder.Entity<TransactionLine>().HasIndex(i => new { i.ConnectionId, i.TransactionId });//to get earliest trx date to reconcile from
            builder.Entity<TransactionLineDateChecksum>().HasKey(i => new { i.ConnectionId, i.Date });

            this.ConfigureColumnsTypes(builder);
        }

        private void ConfigureColumnsTypes(ModelBuilder builder)
        {
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                entityType.SetTableName(entityType.ClrType.Name);

                foreach (var pty in entityType.GetProperties())
                {
                    if (pty.ClrType == typeof(DateTime) || pty.ClrType == typeof(DateTime?))
                    {
                        pty.SetColumnType(pty.PropertyInfo.GetCustomAttributes<DateOnlyAttribute>() != null ? "date" : "datetime2(0)");
                    }
                    else if (pty.ClrType == typeof(DateTimeOffset) || pty.ClrType == typeof(DateTimeOffset?))
                    {
                        pty.SetColumnType("datetimeoffset(0)");
                    }
                    else if ((pty.ClrType == typeof(decimal) || pty.ClrType == typeof(decimal?)))
                    {
                        pty.SetPrecision(11 + 8);
                        pty.SetScale(8);
                    }
                }
            }
        }
    }
}
