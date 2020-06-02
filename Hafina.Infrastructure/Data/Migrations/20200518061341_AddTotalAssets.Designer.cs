﻿// <auto-generated />
using System;
using Hafina.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hafina.Infrastructure.Data.Migrations
{
    [DbContext(typeof(HafinaContext))]
    [Migration("20200518061341_AddTotalAssets")]
    partial class AddTotalAssets
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.3.20181.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hafina.Core.Entities.BalanceSheet", b =>
                {
                    b.Property<int>("BalanceSheetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CashAndCashEuivalents")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CommercialAdvantage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CurrentAssets")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FixedAssets")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Inventory")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("LongTermAccountReceivable")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LongTermAssets")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LongTermFinacialInvestments")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LongTermLiabilities")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtherCurrentAssets")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtherLongTermAssets")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OwnersEquity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RealEstateInvestment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ShortTermAccountReceivables")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ShortTermFinancialInvestment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ShortTermLiabilities")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalAssets")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BalanceSheetId");

                    b.HasIndex("CompanyId");

                    b.ToTable("BalanceSheet");
                });

            modelBuilder.Entity("Hafina.Core.Entities.BusinessResult", b =>
                {
                    b.Property<int>("BusinessResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("AccountingProfitBeforeTax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("BasicEarningsPerShare")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("BenefitsOfMinorityShareholders")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<decimal?>("CostOfGoodsSold")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("CurrentCorporateIncomeTaxExpense")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("DeclineEarningsPerShare")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("DeductibleRevenue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("DeferredCorporateIncomeTaxExpense")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Dividend")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("EnterpriseCostManagement")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("FinancialExpenses")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("GrossProfitOfGoodsAndServices")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("InterestExpenses")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal?>("NetProfitFromBusinessActivities")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("NetSalesOfGoodsAndServices")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("OtherCosts")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("OtherIncome")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("OtherProfits")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ProfitAfterTaxCorporateIncome")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ProfitAfterTaxOfTheParentCompany")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ProfitOrLossInJointVenturesOrAssociates")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("RevenueFromFinancialActivities")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("SalesOfGoodsAndServices")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("SellingExpenses")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BusinessResultId");

                    b.HasIndex("CompanyId");

                    b.ToTable("BusinessResult");
                });

            modelBuilder.Entity("Hafina.Core.Entities.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Hafina.Core.Entities.SerilogEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Exception")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogEvent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageTemplate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Properties")
                        .HasColumnType("xml");

                    b.Property<DateTimeOffset>("TimeStamp")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Serilog");
                });

            modelBuilder.Entity("Hafina.Core.Entities.BalanceSheet", b =>
                {
                    b.HasOne("Hafina.Core.Entities.Company", "Company")
                        .WithMany("BalanceSheets")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hafina.Core.Entities.BusinessResult", b =>
                {
                    b.HasOne("Hafina.Core.Entities.Company", "Company")
                        .WithMany("BusinessResults")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}