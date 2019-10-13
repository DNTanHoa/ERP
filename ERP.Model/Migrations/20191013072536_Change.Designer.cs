﻿// <auto-generated />
using System;
using ERP.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ERP.Model.Migrations
{
    [DbContext(typeof(ERPContext))]
    [Migration("20191013072536_Change")]
    partial class Change
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ERP.Model.Models.Roles", b =>
                {
                    b.Property<Guid>("Oid")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OptimisticLockField")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("createDate");

                    b.Property<bool>("isActive");

                    b.Property<string>("name");

                    b.Property<DateTime>("updateDate");

                    b.HasKey("Oid");

                    b.ToTable("role");
                });

            modelBuilder.Entity("ERP.Model.Models.Users", b =>
                {
                    b.Property<Guid>("Oid")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OptimisticLockField")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("createDate");

                    b.Property<bool>("isActive");

                    b.Property<string>("storedPassword");

                    b.Property<DateTime>("updateDate");

                    b.Property<string>("username");

                    b.HasKey("Oid");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
