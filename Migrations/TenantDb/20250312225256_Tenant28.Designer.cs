﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MohsinQBO.Migrations.TenantDb
{
    [DbContext(typeof(TenantDbContext))]
    [Migration("20250312225256_Tenant28")]
    partial class Tenant28
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APAgingDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Col1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Col4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Current")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Total")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vendor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("APAgingDetail");
                });

            modelBuilder.Entity("ARAgingDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("cust_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doc_num")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("due_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subt_amount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subt_open_bal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tx_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("txn_type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ARAgingDetail");
                });

            modelBuilder.Entity("AccountEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountAlias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountSubType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AcctNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Classification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrencyRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("CurrentBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("CurrentBalanceWithSubAccounts")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullyQualifiedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QBId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("SubAccount")
                        .HasColumnType("bit");

                    b.Property<string>("TaxCodeRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TxnLocationType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QBId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ARAccountRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("AlternatePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("BalanceWithJobs")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BillAddr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("BillWithParent")
                        .HasColumnType("bit");

                    b.Property<string>("BusinessNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrencyRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerTypeRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefaultTaxCodeRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullyQualifiedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GSTIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GSTRegistrationType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GivenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsProject")
                        .HasColumnType("bit");

                    b.Property<bool?>("Job")
                        .HasColumnType("bit");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("MetaData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("OpenBalanceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ParentRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethodRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferredDeliveryMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryEmailAddr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryTaxIdentifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrintOnCheckName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QBId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResaleNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesTermRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondaryTaxIdentifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipAddr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxExemptionReasonId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Taxable")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebAddr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("GeneralLedgerDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("account_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("credit_amt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cust_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("debt_amt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doc_num")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emp_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("klass_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("memo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rbal_nat_amount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("split_acc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subt_nat_amount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tx_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("txn_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vend_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GeneralLedgerDetail");
                });

            modelBuilder.Entity("Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("APAccountRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AcctNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("AlternatePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BillAddr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("BillRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BusinessNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("CostRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CurrencyRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GSTIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GSTRegistrationType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GivenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("HasTPAR")
                        .HasColumnType("bit");

                    b.Property<string>("MetaData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherContactInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryEmailAddr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrintOnCheckName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QBId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipAddr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("T4AEligible")
                        .HasColumnType("bit");

                    b.Property<bool?>("T5018Eligible")
                        .HasColumnType("bit");

                    b.Property<string>("TaxIdentifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxReportingBasis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TermRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Vendor1099")
                        .HasColumnType("bit");

                    b.Property<string>("VendorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorPaymentBankDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebAddr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });
#pragma warning restore 612, 618
        }
    }
}
