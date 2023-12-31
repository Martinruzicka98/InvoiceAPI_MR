﻿// <auto-generated />
using System;
using InvoiceAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InvoiceAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230816203005_AddInvoiceTable")]
    partial class AddInvoiceTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InvoiceAPI.Models.Invoice", b =>
                {
                    b.Property<Guid>("UUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Castka")
                        .HasColumnType("float");

                    b.Property<DateTime>("DatumPosledniVyzvy")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumSplatnosti")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumUskutecneniPlneni")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumVystaveni")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumVytvoreni")
                        .HasColumnType("datetime2");

                    b.Property<string>("FormaUhrady")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IcoDodavatele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IcoOdberatele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JmenoDodavatele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JmenoOdberatele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UUID");

                    b.ToTable("Invoices");
                });
#pragma warning restore 612, 618
        }
    }
}
