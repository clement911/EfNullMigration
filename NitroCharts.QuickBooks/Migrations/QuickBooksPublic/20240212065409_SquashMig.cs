using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NitroCharts.QuickBooks.Migrations.QuickBooksPublic
{
    /// <inheritdoc />
    public partial class SquashMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "quickbooks");

            migrationBuilder.CreateTable(
                name: "Account",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, collation: "Latin1_General_100_CI_AI_SC"),
                    AcctNum = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ParentAccountId = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    SubAccount = table.Column<bool>(type: "bit", nullable: true),
                    Classification = table.Column<string>(type: "varchar(9)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Level1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level4 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level5 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TxnLocationType = table.Column<string>(type: "nvarchar(19)", maxLength: 19, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    AccountType = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CurrentBalanceWithSubAccounts = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    AccountAlias = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    AccountSubType = table.Column<string>(type: "varchar(100)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CurrentBalance = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    APAccountId = table.Column<long>(type: "bigint", nullable: true),
                    SalesTermId = table.Column<long>(type: "bigint", nullable: true),
                    GlobalTaxCalculation = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TransactionLocationType = table.Column<string>(type: "varchar(24)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    DueDate = table.Column<DateTime>(type: "date", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    DocNumber = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ExchangeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    IncludeInAnnualTPAR = table.Column<bool>(type: "bit", nullable: true),
                    HomeBalance = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    RecurringTransactionId = table.Column<long>(type: "bigint", nullable: true),
                    Balance = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TotalTax = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "BillLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    BillId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    LineNum = table.Column<short>(type: "smallint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: true),
                    DetailType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxInclusiveAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    PriceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    AccountId = table.Column<long>(type: "bigint", nullable: true),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    MarkupInfo_PriceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    MarkupInfo_Percent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    MarkupInfo_MarkUpIncomeAccountId = table.Column<long>(type: "bigint", nullable: true),
                    BillableStatus = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Qty = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TDSSectionTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillLine", x => new { x.ConnectionId, x.BillId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "BillPayment",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
                    TotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PayType = table.Column<string>(type: "varchar(10)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    DocNumber = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TxnDate = table.Column<DateTime>(type: "date", nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    APAccountId = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    TransactionLocationType = table.Column<string>(type: "varchar(19)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    CheckPayment_BankAccountId = table.Column<long>(type: "bigint", nullable: true),
                    CheckPayment_PrintStatus = table.Column<string>(type: "varchar(13)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CreditCardPayment_CCAccountId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillPayment", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "BillPaymentLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    BillPaymentId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: false),
                    TxnId = table.Column<long>(type: "bigint", nullable: false),
                    TxnType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TxnLineId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillPaymentLine", x => new { x.ConnectionId, x.BillPaymentId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "BillTaxLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    BillId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxRateId = table.Column<long>(type: "bigint", nullable: true),
                    NetAmountTaxable = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PercentBased = table.Column<bool>(type: "bit", nullable: true),
                    TaxInclusiveAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    OverrideDeltaAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillTaxLine", x => new { x.ConnectionId, x.BillId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "Budget",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true),
                    BudgetEntryType = table.Column<string>(type: "varchar(9)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BudgetType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budget", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "BudgetLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    BudgetId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    BudgetDate = table.Column<DateTime>(type: "date", nullable: true),
                    AccountId = table.Column<long>(type: "bigint", nullable: true),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetLine", x => new { x.ConnectionId, x.BudgetId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "BundleItemLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    BundleItemId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    Qty = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BundleItemLine", x => new { x.ConnectionId, x.BundleItemId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "Class",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<string>(type: "varchar(32)", nullable: false, collation: "Latin1_General_100_BIN2"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    SubClass = table.Column<bool>(type: "bit", nullable: true),
                    ParentId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Level1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level4 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level5 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "CompanyCurrency",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    Code = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCurrency", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "CompanyInfo",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    SupportedLanguages = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Country = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    EmailAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    FiscalYearStartMonth = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    LegalName = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CompanyStartDate = table.Column<DateTime>(type: "date", nullable: true),
                    NameValuesJSON = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInfo", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "CreditCardPayment",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    CreditCardAccountId = table.Column<long>(type: "bigint", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    BankAccountId = table.Column<long>(type: "bigint", nullable: true),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
                    TxnDate = table.Column<DateTime>(type: "date", nullable: true),
                    Memo = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrintStatus = table.Column<string>(type: "varchar(13)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CheckNum = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true, collation: "Latin1_General_100_CI_AI_SC")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCardPayment", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "CreditMemo",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillEmailAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TxnDate = table.Column<DateTime>(type: "date", nullable: true),
                    CustomField1 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomField2 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomField3 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    PrintStatus = table.Column<string>(type: "varchar(13)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    SalesTermId = table.Column<long>(type: "bigint", nullable: true),
                    GlobalTaxCalculation = table.Column<string>(type: "varchar(13)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    InvoiceId = table.Column<long>(type: "bigint", nullable: true),
                    TransactionLocationType = table.Column<string>(type: "nvarchar(24)", maxLength: 24, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ApplyTaxAfterDiscount = table.Column<bool>(type: "bit", nullable: true),
                    DocNumber = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomerMemo = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TotalTax = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PaymentMethodId = table.Column<long>(type: "bigint", nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipToAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipToAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    EmailStatus = table.Column<string>(type: "varchar(10)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    BillAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    BillAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    HomeBalance = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    RemainingCredit = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    RecurringTransactionId = table.Column<long>(type: "bigint", nullable: true),
                    TaxExemptionId = table.Column<long>(type: "bigint", nullable: true),
                    Balance = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    HomeTotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditMemo", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "CreditMemoLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    CreditMemoId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    LineNum = table.Column<short>(type: "smallint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: true),
                    DetailType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxInclusiveAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    DiscountAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    SpecialItemId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    MarkupInfo_PriceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    MarkupInfo_Percent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    MarkupInfo_MarkUpIncomeAccountId = table.Column<long>(type: "bigint", nullable: true),
                    ItemAccountId = table.Column<long>(type: "bigint", nullable: true),
                    ServiceDate = table.Column<DateTime>(type: "date", nullable: true),
                    DiscountRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Qty = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxClassificationId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    DiscountAccountId = table.Column<long>(type: "bigint", nullable: true),
                    PercentBased = table.Column<bool>(type: "bit", nullable: true),
                    DiscountPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    GroupLineId = table.Column<long>(type: "bigint", nullable: true),
                    GroupQuantity = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    GroupItemId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditMemoLine", x => new { x.ConnectionId, x.CreditMemoId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "CreditMemoTaxLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    CreditMemoId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxRateId = table.Column<long>(type: "bigint", nullable: true),
                    NetAmountTaxable = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PercentBased = table.Column<bool>(type: "bit", nullable: true),
                    TaxInclusiveAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    OverrideDeltaAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditMemoTaxLine", x => new { x.ConnectionId, x.CreditMemoId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Title = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    GivenName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Suffix = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    FamilyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrimaryEmailAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ResaleNum = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    SecondaryTaxIdentifier = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ARAccountId = table.Column<long>(type: "bigint", nullable: true),
                    DefaultTaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    PreferredDeliveryMethod = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    GSTIN = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    SalesTermId = table.Column<long>(type: "bigint", nullable: true),
                    CustomerTypeId = table.Column<long>(type: "bigint", nullable: true),
                    FaxNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BusinessNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillWithParent = table.Column<bool>(type: "bit", nullable: true),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    MobileNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Job = table.Column<bool>(type: "bit", nullable: true),
                    PrimaryPhoneNumber = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    OpenBalanceDate = table.Column<DateTime>(type: "date", nullable: true),
                    Taxable = table.Column<bool>(type: "bit", nullable: true),
                    AlternatePhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    WebAddressUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    ShippingAddress_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShippingAddress_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShippingAddress_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShippingAddress_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShippingAddress_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShippingAddress_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShippingAddress_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShippingAddress_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShippingAddress_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShippingAddress_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShippingAddress_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillingAddress_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillingAddress_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillingAddress_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillingAddress_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillingAddress_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillingAddress_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillingAddress_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillingAddress_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillingAddress_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    BillingAddress_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    BillingAddress_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PaymentMethodId = table.Column<long>(type: "bigint", nullable: true),
                    IsProject = table.Column<bool>(type: "bit", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrimaryTaxIdentifier = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    GSTRegistrationType = table.Column<string>(type: "varchar(15)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    PrintOnCheckName = table.Column<string>(type: "nvarchar(110)", maxLength: 110, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level4 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level5 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level = table.Column<byte>(type: "tinyint", nullable: true),
                    TaxExemptionReasonId = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "CustomerType",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerType", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "Deposit",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    DepositToAccountId = table.Column<long>(type: "bigint", nullable: true),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    GlobalTaxCalculation = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ExchangeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    TxnSource = table.Column<string>(type: "varchar(100)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TxnDate = table.Column<DateTime>(type: "date", nullable: true),
                    CashBack_AccountId = table.Column<long>(type: "bigint", nullable: true),
                    CashBack_Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    CashBack_Memo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TransactionLocationType = table.Column<string>(type: "varchar(24)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TotalTax = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    RecurringTransactionId = table.Column<long>(type: "bigint", nullable: true),
                    TotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    HomeTotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposit", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "DepositLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    DepositId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    LineNum = table.Column<short>(type: "smallint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: true),
                    DetailType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    LinkedTxnId = table.Column<long>(type: "bigint", nullable: false),
                    LinkedTxnType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    LinkedTxnLineId = table.Column<long>(type: "bigint", nullable: true),
                    AccountId = table.Column<long>(type: "bigint", nullable: true),
                    PaymentMethodId = table.Column<long>(type: "bigint", nullable: true),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CheckNum = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TaxApplicableOn = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    TxnType = table.Column<string>(type: "varchar(21)", nullable: true, collation: "Latin1_General_100_BIN2")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositLine", x => new { x.ConnectionId, x.DepositId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "DepositTaxLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    DepositId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxRateId = table.Column<long>(type: "bigint", nullable: true),
                    NetAmountTaxable = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PercentBased = table.Column<bool>(type: "bit", nullable: true),
                    TaxInclusiveAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    OverrideDeltaAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositTaxLine", x => new { x.ConnectionId, x.DepositId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    PrimaryAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrimaryAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrimaryAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrimaryAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrimaryAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrimaryAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrimaryAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrimaryAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrimaryAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrimaryAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PrimaryAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PrimaryEmailAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    DisplayName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Title = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillableTime = table.Column<bool>(type: "bit", nullable: true),
                    GivenName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    SSN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrimaryPhone = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    ReleasedDate = table.Column<DateTime>(type: "date", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Gender = table.Column<string>(type: "varchar(6)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    HiredDate = table.Column<DateTime>(type: "date", nullable: true),
                    BillRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Organization = table.Column<bool>(type: "bit", nullable: true),
                    Suffix = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    FamilyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrintOnCheckName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    EmployeeNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    V4IDPseudonym = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CostRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "Estimate",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    DocNumber = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillEmailAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    ShipFromAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipFromAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipDate = table.Column<DateTime>(type: "date", nullable: true),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    PrintStatus = table.Column<string>(type: "varchar(13)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    SalesTermId = table.Column<long>(type: "bigint", nullable: true),
                    GlobalTaxCalculation = table.Column<string>(type: "varchar(13)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TransactionLocationType = table.Column<string>(type: "varchar(64)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    DueDate = table.Column<DateTime>(type: "date", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomerMemo = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    EmailStatus = table.Column<string>(type: "varchar(10)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ExchangeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TotalTax = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipToAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipToAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    ShipMethod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    BillAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ApplyTaxAfterDiscount = table.Column<bool>(type: "bit", nullable: true),
                    TotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    RecurringTransactionId = table.Column<long>(type: "bigint", nullable: true),
                    TaxExemptionId = table.Column<long>(type: "bigint", nullable: true),
                    HomeTotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    FreeFormAddress = table.Column<bool>(type: "bit", nullable: true),
                    CustomField1 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomField2 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomField3 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TxnStatus = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    AcceptedDate = table.Column<DateTime>(type: "date", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "date", nullable: true),
                    AcceptedBy = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estimate", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "EstimateLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    EstimateId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    LineNum = table.Column<short>(type: "smallint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: true),
                    DetailType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxInclusiveAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    DiscountAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    SpecialItemId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    MarkupInfo_PriceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    MarkupInfo_Percent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    MarkupInfo_MarkUpIncomeAccountId = table.Column<long>(type: "bigint", nullable: true),
                    ItemAccountId = table.Column<long>(type: "bigint", nullable: true),
                    ServiceDate = table.Column<DateTime>(type: "date", nullable: true),
                    DiscountRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Qty = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxClassificationId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    DiscountAccountId = table.Column<long>(type: "bigint", nullable: true),
                    PercentBased = table.Column<bool>(type: "bit", nullable: true),
                    DiscountPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    GroupLineId = table.Column<long>(type: "bigint", nullable: true),
                    GroupQuantity = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    GroupItemId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstimateLine", x => new { x.ConnectionId, x.EstimateId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "EstimateTaxLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    EstimateId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxRateId = table.Column<long>(type: "bigint", nullable: true),
                    NetAmountTaxable = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PercentBased = table.Column<bool>(type: "bit", nullable: true),
                    TaxInclusiveAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    OverrideDeltaAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstimateTaxLine", x => new { x.ConnectionId, x.EstimateId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRate",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    SourceCurrencyCode = table.Column<string>(type: "char(3)", nullable: false, collation: "Latin1_General_100_BIN2"),
                    TargetCurrencyCode = table.Column<string>(type: "char(3)", nullable: false, collation: "Latin1_General_100_BIN2"),
                    AsOfDate = table.Column<DateTime>(type: "date", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRate", x => new { x.ConnectionId, x.SourceCurrencyCode, x.TargetCurrencyCode, x.AsOfDate });
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    DocNumber = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillEmailAddress_To = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillEmailAddress_CC = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillEmailAddress_BCC = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    ShipFromAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipFromAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipDate = table.Column<DateTime>(type: "date", nullable: true),
                    TrackingNum = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    PrintStatus = table.Column<string>(type: "varchar(13)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    SalesTermId = table.Column<long>(type: "bigint", nullable: true),
                    TxnSource = table.Column<string>(type: "varchar(50)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    DepositToAccountId = table.Column<long>(type: "bigint", nullable: true),
                    GlobalTaxCalculation = table.Column<string>(type: "varchar(13)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    AllowOnlineACHPayment = table.Column<bool>(type: "bit", nullable: true),
                    TransactionLocationType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    DueDate = table.Column<DateTime>(type: "date", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomerMemo = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    EmailStatus = table.Column<string>(type: "varchar(10)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ExchangeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Deposit = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TotalTax = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    AllowOnlineCreditCardPayment = table.Column<bool>(type: "bit", nullable: true),
                    ShipToAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipToAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    ShipMethod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    BillAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ApplyTaxAfterDiscount = table.Column<bool>(type: "bit", nullable: true),
                    HomeBalance = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Delivery_Type = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Delivery_Time = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    TotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    InvoiceLink = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    RecurringTransactionId = table.Column<long>(type: "bigint", nullable: true),
                    TaxExemptionId = table.Column<long>(type: "bigint", nullable: true),
                    Balance = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    HomeTotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    FreeFormAddress = table.Column<bool>(type: "bit", nullable: true),
                    CustomField1 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomField2 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomField3 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "InvoiceLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    InvoiceId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    LineNum = table.Column<short>(type: "smallint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: true),
                    DetailType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxInclusiveAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    DiscountAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    SpecialItemId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    MarkupInfo_PriceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    MarkupInfo_Percent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    MarkupInfo_MarkUpIncomeAccountId = table.Column<long>(type: "bigint", nullable: true),
                    ItemAccountId = table.Column<long>(type: "bigint", nullable: true),
                    ServiceDate = table.Column<DateTime>(type: "date", nullable: true),
                    DiscountRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Qty = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxClassificationId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    DiscountAccountId = table.Column<long>(type: "bigint", nullable: true),
                    PercentBased = table.Column<bool>(type: "bit", nullable: true),
                    DiscountPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    GroupLineId = table.Column<long>(type: "bigint", nullable: true),
                    GroupQuantity = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    GroupItemId = table.Column<long>(type: "bigint", nullable: true),
                    TDSSectionTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceLine", x => new { x.ConnectionId, x.InvoiceId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "InvoiceTaxLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    InvoiceId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxRateId = table.Column<long>(type: "bigint", nullable: true),
                    NetAmountTaxable = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PercentBased = table.Column<bool>(type: "bit", nullable: true),
                    TaxInclusiveAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    OverrideDeltaAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceTaxLine", x => new { x.ConnectionId, x.InvoiceId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "Item",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    ItemCategoryType = table.Column<string>(type: "varchar(7)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    InvStartDate = table.Column<DateTime>(type: "date", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    QtyOnHand = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    AssetAccountId = table.Column<long>(type: "bigint", nullable: true),
                    Sku = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    SalesTaxIncluded = table.Column<bool>(type: "bit", nullable: true),
                    TrackQtyOnHand = table.Column<bool>(type: "bit", nullable: true),
                    SalesTaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    PurchaseTaxIncluded = table.Column<bool>(type: "bit", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    AbatementRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ReverseChargeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    SubItem = table.Column<bool>(type: "bit", nullable: true),
                    Taxable = table.Column<bool>(type: "bit", nullable: true),
                    UQCDisplayText = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ReorderPoint = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PurchaseDesc = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrefVendorId = table.Column<long>(type: "bigint", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    UQCId = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PurchaseTaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ServiceType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    PurchaseCost = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Level1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level4 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level5 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level = table.Column<int>(type: "int", nullable: true),
                    IncomeAccountId = table.Column<long>(type: "bigint", nullable: true),
                    ExpenseAccountId = table.Column<long>(type: "bigint", nullable: true),
                    TaxClassificationId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    PrintGroupedItems = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "JournalEntry",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    DocNumber = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TxnDate = table.Column<DateTime>(type: "date", nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TransactionLocationType = table.Column<string>(type: "varchar(64)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TotalTax = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    GlobalTaxCalculation = table.Column<string>(type: "varchar(13)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Adjustment = table.Column<bool>(type: "bit", nullable: true),
                    RecurringTransactionId = table.Column<long>(type: "bigint", nullable: true),
                    TotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    HomeTotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalEntry", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "JournalEntryLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    JournalEntryId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    LineNum = table.Column<short>(type: "smallint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: true),
                    DetailType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ServiceDate = table.Column<DateTime>(type: "date", nullable: true),
                    JournalCodeId = table.Column<long>(type: "bigint", nullable: true),
                    PostingType = table.Column<string>(type: "varchar(6)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    AccountId = table.Column<long>(type: "bigint", nullable: true),
                    TaxApplicableOn = table.Column<string>(type: "varchar(8)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    TaxInclusiveAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    BillableStatus = table.Column<string>(type: "varchar(13)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TaxAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalEntryLine", x => new { x.ConnectionId, x.JournalEntryId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "JournalEntryTaxLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    JournalEntryId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxRateId = table.Column<long>(type: "bigint", nullable: true),
                    NetAmountTaxable = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PercentBased = table.Column<bool>(type: "bit", nullable: true),
                    TaxInclusiveAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    OverrideDeltaAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalEntryTaxLine", x => new { x.ConnectionId, x.JournalEntryId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "Location",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    Level1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level4 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level5 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    TotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PaymentMethodId = table.Column<long>(type: "bigint", nullable: true),
                    UnappliedAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    DepositToAccountId = table.Column<long>(type: "bigint", nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TxnSource = table.Column<string>(type: "varchar(50)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ARAccountId = table.Column<long>(type: "bigint", nullable: true),
                    TxnDate = table.Column<DateTime>(type: "date", nullable: true),
                    CreditCardPayment_CreditChargeInfo_CcExpiryMonth = table.Column<byte>(type: "tinyint", nullable: true),
                    CreditCardPayment_CreditChargeInfo_ProcessPayment = table.Column<bool>(type: "bit", nullable: true),
                    CreditCardPayment_CreditChargeInfo_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreditCardPayment_CreditChargeInfo_Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    CreditCardPayment_CreditChargeInfo_NameOnAcct = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreditCardPayment_CreditChargeInfo_CcExpiryYear = table.Column<short>(type: "smallint", nullable: true),
                    CreditCardPayment_CreditChargeInfo_Type = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CreditCardPayment_CreditChargeInfo_BillAddrStreet = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreditCardPayment_Response_Status = table.Column<string>(type: "varchar(9)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CreditCardPayment_esponse_AuthCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreditCardPayment_Response_TxnAuthorizationTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    CreditCardPayment_Response_CCTransId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TransactionLocationType = table.Column<string>(type: "varchar(19)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    PaymentRefNum = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "PaymentLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    PaymentId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: false),
                    TxnId = table.Column<long>(type: "bigint", nullable: false),
                    TxnType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TxnLineId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentLine", x => new { x.ConnectionId, x.PaymentId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    Type = table.Column<string>(type: "varchar(15)", nullable: true, collation: "Latin1_General_100_BIN2")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "Preferences",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    EmailMessagesPrefs_InvoiceMessage_Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    EmailMessagesPrefs_InvoiceMessage_Subject = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    EmailMessagesPrefs_EstimateMessage_Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    EmailMessagesPrefs_EstimateMessage_Subject = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    EmailMessagesPrefs_SalesReceiptMessage_Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    EmailMessagesPrefs_SalesReceiptMessage_Subject = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    EmailMessagesPrefs_StatementMessage_Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    EmailMessagesPrefs_StatementMessage_Subject = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ProductAndServicesPrefs_QuantityWithPriceAndRate = table.Column<bool>(type: "bit", nullable: true),
                    ProductAndServicesPrefs_QuantityOnHand = table.Column<bool>(type: "bit", nullable: true),
                    ProductAndServicesPrefs_ForSales = table.Column<bool>(type: "bit", nullable: true),
                    ProductAndServicesPrefs_ForPurchase = table.Column<bool>(type: "bit", nullable: true),
                    ReportPrefs_ReportBasis = table.Column<string>(type: "varchar(7)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ReportPrefs_CalcAgingReportFromTxnDate = table.Column<bool>(type: "bit", nullable: true),
                    AccountingInfoPrefs_FirstMonthOfFiscalYear = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    AccountingInfoPrefs_UseAccountNumbers = table.Column<bool>(type: "bit", nullable: true),
                    AccountingInfoPrefs_TaxYearMonth = table.Column<string>(type: "varchar(9)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    AccountingInfoPrefs_ClassTrackingPerTxn = table.Column<bool>(type: "bit", nullable: true),
                    AccountingInfoPrefs_ClassTrackingPerTxnLine = table.Column<bool>(type: "bit", nullable: true),
                    AccountingInfoPrefs_TrackLocations = table.Column<bool>(type: "bit", nullable: true),
                    AccountingInfoPrefs_TaxForm = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    AccountingInfoPrefs_CustomerTerminology = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    AccountingInfoPrefs_BookCloseDate = table.Column<DateTime>(type: "date", nullable: true),
                    AccountingInfoPrefs_DepartmentTerminology = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    SalesFormsPrefs_SalesEmailCc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    SalesFormsPrefs_SalesEmailBcc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    SalesFormsPrefs_UsingProgressInvoicing = table.Column<bool>(type: "bit", nullable: true),
                    SalesFormsPrefs_AllowServiceDate = table.Column<bool>(type: "bit", nullable: true),
                    SalesFormsPrefs_EstimateMessage = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    SalesFormsPrefs_EmailCopyToCompany = table.Column<bool>(type: "bit", nullable: true),
                    SalesFormsPrefs_DefaultCustomerMessage = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    SalesFormsPrefs_AllowShipping = table.Column<bool>(type: "bit", nullable: true),
                    SalesFormsPrefs_DefaultDiscountAccount = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    SalesFormsPrefs_IPNSupportEnabled = table.Column<bool>(type: "bit", nullable: true),
                    SalesFormsPrefs_ETransactionPaymentEnabled = table.Column<bool>(type: "bit", nullable: true),
                    SalesFormsPrefs_DefaultTermsId = table.Column<long>(type: "bigint", nullable: true),
                    SalesFormsPrefs_AllowDeposit = table.Column<bool>(type: "bit", nullable: true),
                    SalesFormsPrefs_UsingPriceLevels = table.Column<bool>(type: "bit", nullable: true),
                    SalesFormsPrefs_DefaultShippingAccount = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    SalesFormsPrefs_ETransactionAttachPDF = table.Column<bool>(type: "bit", nullable: true),
                    SalesFormsPrefs_CustomTxnNumbers = table.Column<bool>(type: "bit", nullable: true),
                    SalesFormsPrefs_ETransactionEnabledStatus = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    SalesFormsPrefs_AllowEstimates = table.Column<bool>(type: "bit", nullable: true),
                    SalesFormsPrefs_AllowDiscount = table.Column<bool>(type: "bit", nullable: true),
                    SalesFormsPrefs_AutoApplyCredit = table.Column<bool>(type: "bit", nullable: true),
                    SalesFormsPrefs_AutoApplyPayments = table.Column<bool>(type: "bit", nullable: true),
                    SalesFormsPrefs_CustomFieldJSON = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    VendorAndPurchasesPrefs_DefaultMarkupAccountId = table.Column<long>(type: "bigint", nullable: true),
                    VendorAndPurchasesPrefs_TrackingByCustomer = table.Column<bool>(type: "bit", nullable: true),
                    VendorAndPurchasesPrefs_DefaultTermsId = table.Column<long>(type: "bigint", nullable: true),
                    VendorAndPurchasesPrefs_BillableExpenseTracking = table.Column<bool>(type: "bit", nullable: true),
                    VendorAndPurchasesPrefs_DefaultMarkup = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    VendorAndPurchasesPrefs_TPAREnabled = table.Column<bool>(type: "bit", nullable: true),
                    VendorAndPurchasesPrefs_POCustomFieldJSON = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxPrefs_PartnerTaxEnabled = table.Column<bool>(type: "bit", nullable: true),
                    TaxPrefs_TaxGroupCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TaxPrefs_UsingSalesTax = table.Column<bool>(type: "bit", nullable: true),
                    OtherPrefs_NameValuesJSON = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TimeTrackingPrefs_WorkWeekStartDate = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TimeTrackingPrefs_MarkTimeEntriesBillable = table.Column<bool>(type: "bit", nullable: true),
                    TimeTrackingPrefs_ShowBillRateToAll = table.Column<bool>(type: "bit", nullable: true),
                    TimeTrackingPrefs_BillCustomers = table.Column<bool>(type: "bit", nullable: true),
                    TimeTrackingPrefs_UseServices = table.Column<bool>(type: "bit", nullable: true),
                    CurrencyPrefs_MultiCurrencyEnabled = table.Column<bool>(type: "bit", nullable: true),
                    CurrencyPrefs_HomeCurrency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferences", x => x.ConnectionId);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    AccountId = table.Column<long>(type: "bigint", nullable: true),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    PrintStatus = table.Column<string>(type: "varchar(13)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    RemitToAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    RemitToAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    RemitToAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    RemitToAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    RemitToAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    RemitToAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    RemitToAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    RemitToAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    RemitToAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    RemitToAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    RemitToAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TxnSource = table.Column<string>(type: "varchar(100)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    GlobalTaxCalculation = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TransactionLocationType = table.Column<string>(type: "varchar(24)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    DocNumber = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Credit = table.Column<bool>(type: "bit", nullable: true),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TotalTax = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PaymentMethodId = table.Column<long>(type: "bigint", nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    IncludeInAnnualTPAR = table.Column<bool>(type: "bit", nullable: true),
                    TotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    RecurringTransactionId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "PurchaseLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    LineNum = table.Column<short>(type: "smallint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: true),
                    DetailType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxInclusiveAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    PriceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    AccountId = table.Column<long>(type: "bigint", nullable: true),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    MarkupInfo_PriceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    MarkupInfo_Percent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    MarkupInfo_MarkUpIncomeAccountId = table.Column<long>(type: "bigint", nullable: true),
                    BillableStatus = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Qty = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseLine", x => new { x.ConnectionId, x.PurchaseId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    APAccountId = table.Column<long>(type: "bigint", nullable: true),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    CustomField1 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomField2 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomField3 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    POEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    SalesTermId = table.Column<long>(type: "bigint", nullable: true),
                    GlobalTaxCalculation = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Memo = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    POStatus = table.Column<string>(type: "varchar(6)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TransactionLocationType = table.Column<string>(type: "varchar(24)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    DueDate = table.Column<DateTime>(type: "date", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    DocNumber = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipMethod = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TotalTax = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipToCustomerId = table.Column<long>(type: "bigint", nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    VendorAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    VendorAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    VendorAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    VendorAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    VendorAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    VendorAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    VendorAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    VendorAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    VendorAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    VendorAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    VendorAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    EmailStatus = table.Column<string>(type: "varchar(10)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    RecurringTransactionId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseOrderId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    LineNum = table.Column<short>(type: "smallint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: true),
                    DetailType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxInclusiveAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    PriceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    AccountId = table.Column<long>(type: "bigint", nullable: true),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    MarkupInfo_PriceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    MarkupInfo_Percent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    MarkupInfo_MarkUpIncomeAccountId = table.Column<long>(type: "bigint", nullable: true),
                    BillableStatus = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Qty = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderLine", x => new { x.ConnectionId, x.PurchaseOrderId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderTaxLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseOrderId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxRateId = table.Column<long>(type: "bigint", nullable: true),
                    NetAmountTaxable = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PercentBased = table.Column<bool>(type: "bit", nullable: true),
                    TaxInclusiveAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    OverrideDeltaAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderTaxLine", x => new { x.ConnectionId, x.PurchaseOrderId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "PurchaseTaxLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    PurchaseId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxRateId = table.Column<long>(type: "bigint", nullable: true),
                    NetAmountTaxable = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PercentBased = table.Column<bool>(type: "bit", nullable: true),
                    TaxInclusiveAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    OverrideDeltaAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseTaxLine", x => new { x.ConnectionId, x.PurchaseId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "RefundReceipt",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    DepositToAccountId = table.Column<long>(type: "bigint", nullable: true),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PaymentRefNum = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillEmailAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Date = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    CustomField1 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomField2 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomField3 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    PrintStatus = table.Column<string>(type: "varchar(13)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CheckPayment_CheckNum = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CheckPayment_Status = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CheckPayment_NameOnAcct = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CheckPayment_AcctNum = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CheckPayment_BankName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TxnSource = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    GlobalTaxCalculation = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TransactionLocationType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    DocNumber = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomerMemo = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreditCardPayment_CreditChargeInfo_CcExpiryMonth = table.Column<byte>(type: "tinyint", nullable: true),
                    CreditCardPayment_CreditChargeInfo_ProcessPayment = table.Column<bool>(type: "bit", nullable: true),
                    CreditCardPayment_CreditChargeInfo_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreditCardPayment_CreditChargeInfo_Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    CreditCardPayment_CreditChargeInfo_NameOnAcct = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreditCardPayment_CreditChargeInfo_CcExpiryYear = table.Column<short>(type: "smallint", nullable: true),
                    CreditCardPayment_CreditChargeInfo_Type = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CreditCardPayment_CreditChargeInfo_BillAddrStreet = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreditCardPayment_Response_Status = table.Column<string>(type: "varchar(9)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CreditCardPayment_esponse_AuthCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreditCardPayment_Response_TxnAuthorizationTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    CreditCardPayment_Response_CCTransId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TotalTax = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PaymentMethodId = table.Column<long>(type: "bigint", nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipToAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipToAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    PaymentType = table.Column<string>(type: "varchar(10)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    BillAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    BillAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ApplyTaxAfterDiscount = table.Column<bool>(type: "bit", nullable: true),
                    HomeBalance = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    RecurringTransactionId = table.Column<long>(type: "bigint", nullable: true),
                    TotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxExemptionId = table.Column<long>(type: "bigint", nullable: true),
                    Balance = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    HomeTotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundReceipt", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "RefundReceiptLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    RefundReceiptId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    LineNum = table.Column<short>(type: "smallint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: true),
                    DetailType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxInclusiveAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    DiscountAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    SpecialItemId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    MarkupInfo_PriceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    MarkupInfo_Percent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    MarkupInfo_MarkUpIncomeAccountId = table.Column<long>(type: "bigint", nullable: true),
                    ItemAccountId = table.Column<long>(type: "bigint", nullable: true),
                    ServiceDate = table.Column<DateTime>(type: "date", nullable: true),
                    DiscountRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Qty = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxClassificationId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    DiscountAccountId = table.Column<long>(type: "bigint", nullable: true),
                    PercentBased = table.Column<bool>(type: "bit", nullable: true),
                    DiscountPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    GroupLineId = table.Column<long>(type: "bigint", nullable: true),
                    GroupQuantity = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    GroupItemId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundReceiptLine", x => new { x.ConnectionId, x.RefundReceiptId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "RefundReceiptTaxLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    RefundReceiptId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxRateId = table.Column<long>(type: "bigint", nullable: true),
                    NetAmountTaxable = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PercentBased = table.Column<bool>(type: "bit", nullable: true),
                    TaxInclusiveAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    OverrideDeltaAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundReceiptTaxLine", x => new { x.ConnectionId, x.RefundReceiptId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "ReimburseCharge",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ExchangeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    HasBeenInvoiced = table.Column<bool>(type: "bit", nullable: true),
                    HomeTotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TxnDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReimburseCharge", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "ReimburseChargeLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    ReimburseChargeId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    LineNum = table.Column<short>(type: "smallint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: true),
                    MarkupInfo_PriceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    MarkupInfo_Percent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    MarkupInfo_MarkUpIncomeAccountId = table.Column<long>(type: "bigint", nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Qty = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReimburseChargeLine", x => new { x.ConnectionId, x.ReimburseChargeId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "SalesReceipt",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillEmailAddress = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    ShipFromAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipFromAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipFromAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    CustomField1 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomField2 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CustomField3 = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipDate = table.Column<DateTime>(type: "date", nullable: true),
                    TrackingNum = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    PrintStatus = table.Column<string>(type: "varchar(13)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    PaymentRefNum = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TxnSource = table.Column<string>(type: "varchar(50)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    GlobalTaxCalculation = table.Column<string>(type: "varchar(13)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TransactionLocationType = table.Column<string>(type: "varchar(64)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ApplyTaxAfterDiscount = table.Column<bool>(type: "bit", nullable: true),
                    DocNumber = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    DepositToAccountId = table.Column<long>(type: "bigint", nullable: true),
                    CustomerMemo = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    EmailStatus = table.Column<string>(type: "varchar(10)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CreditCardPayment_CreditChargeInfo_CcExpiryMonth = table.Column<byte>(type: "tinyint", nullable: true),
                    CreditCardPayment_CreditChargeInfo_ProcessPayment = table.Column<bool>(type: "bit", nullable: true),
                    CreditCardPayment_CreditChargeInfo_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreditCardPayment_CreditChargeInfo_Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    CreditCardPayment_CreditChargeInfo_NameOnAcct = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreditCardPayment_CreditChargeInfo_CcExpiryYear = table.Column<short>(type: "smallint", nullable: true),
                    CreditCardPayment_CreditChargeInfo_Type = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CreditCardPayment_CreditChargeInfo_BillAddrStreet = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreditCardPayment_Response_Status = table.Column<string>(type: "varchar(9)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CreditCardPayment_esponse_AuthCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreditCardPayment_Response_TxnAuthorizationTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    CreditCardPayment_Response_CCTransId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TotalTax = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PaymentMethodId = table.Column<long>(type: "bigint", nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipToAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ShipToAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ShipToAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    ShipMethod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    BillAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    HomeBalance = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Delivery_Type = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Delivery_Time = table.Column<DateTime>(type: "datetime2(0)", maxLength: 16, nullable: true),
                    RecurringTransactionId = table.Column<long>(type: "bigint", nullable: true),
                    TotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Balance = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    HomeTotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    FreeFormAddress = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReceipt", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "SalesReceiptLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    SalesReceiptId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    LineNum = table.Column<short>(type: "smallint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: true),
                    DetailType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxInclusiveAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    DiscountAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    SpecialItemId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    MarkupInfo_PriceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    MarkupInfo_Percent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    MarkupInfo_MarkUpIncomeAccountId = table.Column<long>(type: "bigint", nullable: true),
                    ItemAccountId = table.Column<long>(type: "bigint", nullable: true),
                    ServiceDate = table.Column<DateTime>(type: "date", nullable: true),
                    DiscountRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Qty = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxClassificationId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    DiscountAccountId = table.Column<long>(type: "bigint", nullable: true),
                    PercentBased = table.Column<bool>(type: "bit", nullable: true),
                    DiscountPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    GroupLineId = table.Column<long>(type: "bigint", nullable: true),
                    GroupQuantity = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    GroupItemId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReceiptLine", x => new { x.ConnectionId, x.SalesReceiptId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "SalesReceiptTaxLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    SalesReceiptId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxRateId = table.Column<long>(type: "bigint", nullable: true),
                    NetAmountTaxable = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    PercentBased = table.Column<bool>(type: "bit", nullable: true),
                    TaxInclusiveAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    OverrideDeltaAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReceiptTaxLine", x => new { x.ConnectionId, x.SalesReceiptId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "TaxAgency",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxTrackedOnSales = table.Column<bool>(type: "bit", nullable: true),
                    TaxTrackedOnPurchases = table.Column<bool>(type: "bit", nullable: true),
                    LastFileDate = table.Column<DateTime>(type: "date", nullable: true),
                    TaxRegistrationNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    TaxAgencyConfig = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxAgency", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "TaxClassification",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<string>(type: "varchar(128)", nullable: false, collation: "Latin1_General_100_BIN2"),
                    ParentId = table.Column<string>(type: "varchar(128)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Code = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Name = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 4096, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Level = table.Column<byte>(type: "tinyint", nullable: true),
                    ApplicableToJSON = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, collation: "Latin1_General_100_CI_AI_SC")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxClassification", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "TaxCode",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<string>(type: "varchar(16)", nullable: false, collation: "Latin1_General_100_BIN2"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    Hidden = table.Column<bool>(type: "bit", nullable: true),
                    Taxable = table.Column<bool>(type: "bit", nullable: true),
                    TaxGroup = table.Column<bool>(type: "bit", nullable: true),
                    TaxCodeConfigType = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxCode", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "TaxCodeRatePurchase",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: false, collation: "Latin1_General_100_BIN2"),
                    Index = table.Column<byte>(type: "tinyint", nullable: false),
                    TaxRateId = table.Column<long>(type: "bigint", nullable: true),
                    TaxTypeApplicable = table.Column<string>(type: "varchar(24)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TaxOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxCodeRatePurchase", x => new { x.ConnectionId, x.TaxCodeId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "TaxCodeRateSales",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: false, collation: "Latin1_General_100_BIN2"),
                    Index = table.Column<byte>(type: "tinyint", nullable: false),
                    TaxRateId = table.Column<long>(type: "bigint", nullable: true),
                    TaxTypeApplicable = table.Column<string>(type: "varchar(24)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TaxOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxCodeRateSales", x => new { x.ConnectionId, x.TaxCodeId, x.Index });
                });

            migrationBuilder.CreateTable(
                name: "TaxPayment",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    Refund = table.Column<bool>(type: "bit", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "date", nullable: true),
                    PaymentAccountId = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PaymentAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxPayment", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "TaxRate",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    RateValue = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    AgencyId = table.Column<long>(type: "bigint", nullable: true),
                    SpecialTaxType = table.Column<string>(type: "varchar(24)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    EffectiveTaxRatesJSON = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    DisplayType = table.Column<string>(type: "varchar(22)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TaxReturnLineId = table.Column<long>(type: "bigint", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true, collation: "Latin1_General_100_CI_AI_SC")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxRate", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "Term",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    DiscountPercent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    DiscountDays = table.Column<short>(type: "smallint", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    Type = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    DayOfMonthDue = table.Column<byte>(type: "tinyint", nullable: true),
                    DiscountDayOfMonth = table.Column<byte>(type: "tinyint", nullable: true),
                    DueNextMonthDays = table.Column<short>(type: "smallint", nullable: true),
                    DueDays = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Term", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "TimeActivity",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    NameOf = table.Column<string>(type: "varchar(8)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    TxnDate = table.Column<DateTime>(type: "date", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
                    Hours = table.Column<short>(type: "smallint", nullable: true),
                    Minutes = table.Column<byte>(type: "tinyint", nullable: true),
                    StartTime = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: true),
                    HourlyRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    BreakHours = table.Column<short>(type: "smallint", nullable: true),
                    BreakMinutes = table.Column<byte>(type: "tinyint", nullable: true),
                    EndTime = table.Column<DateTimeOffset>(type: "datetimeoffset(0)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    PayrollItemId = table.Column<string>(type: "varchar(128)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    BillableStatus = table.Column<string>(type: "varchar(13)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Taxable = table.Column<bool>(type: "bit", nullable: true),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    CostRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeActivity", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "TransactionLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    TransactionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    PersistedAt = table.Column<DateTime>(type: "datetime2(0)", nullable: false),
                    IsCash = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<string>(type: "varchar(64)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    SubType = table.Column<string>(type: "varchar(64)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    DocNumber = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    ExchangeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Currency = table.Column<string>(type: "char(3)", nullable: false, collation: "Latin1_General_100_CI_AI_SC"),
                    DueDate = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    OpenBalance = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ForeignOpenBalance = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    AdjustmentStatus = table.Column<string>(type: "varchar(24)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ARPaidStatus = table.Column<string>(type: "varchar(24)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    APPaidStatus = table.Column<string>(type: "varchar(24)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ClearedStatus = table.Column<string>(type: "varchar(24)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    OnlineBankingStatus = table.Column<string>(type: "varchar(64)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    CheckPrintStatus = table.Column<string>(type: "varchar(24)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    AccountId = table.Column<long>(type: "bigint", nullable: true),
                    DistributionAccountId = table.Column<long>(type: "bigint", nullable: true),
                    SignedDebitAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: false),
                    ForeignEntryAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: false),
                    TaxableStatus = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    HomeAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ForeignAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ForeignTaxAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxableAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ForeignTaxableAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PaymentMethodId = table.Column<long>(type: "bigint", nullable: true),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionLine", x => new { x.ConnectionId, x.Date, x.TransactionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "TransactionLineDateChecksum",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    SHA256Checksum = table.Column<byte[]>(type: "binary(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionLineDateChecksum", x => new { x.ConnectionId, x.Date });
                });

            migrationBuilder.CreateTable(
                name: "Transfer",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ToAccountId = table.Column<long>(type: "bigint", nullable: true),
                    FromAccountId = table.Column<long>(type: "bigint", nullable: true),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TxnDate = table.Column<DateTime>(type: "date", nullable: true),
                    TransactionLocationType = table.Column<string>(type: "varchar(24)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    RecurringTransactionId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfer", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    GivenName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Suffix = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    FamilyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrimaryEmailAddr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    DisplayName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    APAccountId = table.Column<long>(type: "bigint", nullable: true),
                    TermId = table.Column<long>(type: "bigint", nullable: true),
                    GSTIN = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Fax = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BusinessNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    HasTPAR = table.Column<bool>(type: "bit", nullable: true),
                    TaxReportingBasis = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Mobile = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrimaryPhone = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    AlternatePhone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    Vendor1099 = table.Column<bool>(type: "bit", nullable: true),
                    BillRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    WebAddr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    VendorPaymentBankDetail_BankAccountName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    VendorPaymentBankDetail_BankBranchIdentifier = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    VendorPaymentBankDetail_BankAccountNumber = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    VendorPaymentBankDetail_StatementText = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxIdentifier = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    AcctNum = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    GSTRegistrationType = table.Column<string>(type: "varchar(15)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    PrintOnCheckName = table.Column<string>(type: "nvarchar(110)", maxLength: 110, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_State = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Country = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Line5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    BillAddr_Lat = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    BillAddr_Long = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Balance = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    CostRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "VendorCredit",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
                    Currency = table.Column<string>(type: "char(3)", nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    DocNumber = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    PrivateNote = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    GlobalTaxCalculation = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    ExchangeRate = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    APAccountId = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    TxnDate = table.Column<DateTime>(type: "date", nullable: true),
                    IncludeInAnnualTPAR = table.Column<bool>(type: "bit", nullable: true),
                    TransactionLocationType = table.Column<string>(type: "varchar(24)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Balance = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    RecurringTransactionId = table.Column<long>(type: "bigint", nullable: true),
                    TotalAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorCredit", x => new { x.ConnectionId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "VendorCreditLine",
                schema: "quickbooks",
                columns: table => new
                {
                    ConnectionId = table.Column<long>(type: "bigint", nullable: false),
                    VendorCreditId = table.Column<long>(type: "bigint", nullable: false),
                    Index = table.Column<short>(type: "smallint", nullable: false),
                    LineNum = table.Column<short>(type: "smallint", nullable: true),
                    Id = table.Column<long>(type: "bigint", nullable: true),
                    DetailType = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Amount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true, collation: "Latin1_General_100_CI_AI_SC"),
                    TaxAmount = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    TaxInclusiveAmt = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    ItemId = table.Column<long>(type: "bigint", nullable: true),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    PriceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    ClassId = table.Column<string>(type: "varchar(32)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    AccountId = table.Column<long>(type: "bigint", nullable: true),
                    TaxCodeId = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    MarkupInfo_PriceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    MarkupInfo_Percent = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    MarkupInfo_MarkUpIncomeAccountId = table.Column<long>(type: "bigint", nullable: true),
                    BillableStatus = table.Column<string>(type: "varchar(16)", nullable: true, collation: "Latin1_General_100_BIN2"),
                    Qty = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(19,8)", precision: 19, scale: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorCreditLine", x => new { x.ConnectionId, x.VendorCreditId, x.Index });
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLine_ConnectionId_TransactionId",
                schema: "quickbooks",
                table: "TransactionLine",
                columns: new[] { "ConnectionId", "TransactionId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Bill",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "BillLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "BillPayment",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "BillPaymentLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "BillTaxLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Budget",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "BudgetLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "BundleItemLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Class",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "CompanyCurrency",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "CompanyInfo",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "CreditCardPayment",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "CreditMemo",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "CreditMemoLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "CreditMemoTaxLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "CustomerType",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Deposit",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "DepositLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "DepositTaxLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Employee",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Estimate",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "EstimateLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "EstimateTaxLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "ExchangeRate",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Invoice",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "InvoiceLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "InvoiceTaxLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Item",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "JournalEntry",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "JournalEntryLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "JournalEntryTaxLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Location",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Payment",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "PaymentLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "PaymentMethod",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Preferences",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Purchase",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "PurchaseLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "PurchaseOrder",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "PurchaseOrderLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "PurchaseOrderTaxLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "PurchaseTaxLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "RefundReceipt",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "RefundReceiptLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "RefundReceiptTaxLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "ReimburseCharge",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "ReimburseChargeLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "SalesReceipt",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "SalesReceiptLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "SalesReceiptTaxLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "TaxAgency",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "TaxClassification",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "TaxCode",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "TaxCodeRatePurchase",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "TaxCodeRateSales",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "TaxPayment",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "TaxRate",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Term",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "TimeActivity",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "TransactionLine",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "TransactionLineDateChecksum",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Transfer",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "Vendor",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "VendorCredit",
                schema: "quickbooks");

            migrationBuilder.DropTable(
                name: "VendorCreditLine",
                schema: "quickbooks");
        }
    }
}
