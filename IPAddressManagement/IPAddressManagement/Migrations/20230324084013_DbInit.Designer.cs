﻿// <auto-generated />
using System;
using IPAddressManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IPAddressManagement.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230324084013_DbInit")]
    partial class DbInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IPAddressManagement.Models.Customer", b =>
                {
                    b.Property<int>("ID_Customer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Customer"), 1L, 1);

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID_Customer");

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("IPAddressManagement.Models.GroupUser", b =>
                {
                    b.Property<int>("ID_Group")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Group"), 1L, 1);

                    b.Property<string>("Decription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID_Group");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Group");
                });

            modelBuilder.Entity("IPAddressManagement.Models.IPAddresss", b =>
                {
                    b.Property<int>("ID_IPAddress")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_IPAddress"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IPAddressName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ID_IPAddress");

                    b.HasIndex("IPAddressName")
                        .IsUnique();

                    b.ToTable("IPAddress");
                });

            modelBuilder.Entity("IPAddressManagement.Models.RentalContract", b =>
                {
                    b.Property<int>("ID_RentalContract")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_RentalContract"), 1L, 1);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ID_Customer")
                        .HasColumnType("int");

                    b.Property<int?>("ID_IPAddress")
                        .HasColumnType("int");

                    b.Property<int?>("ID_User")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID_RentalContract");

                    b.HasIndex("ID_Customer");

                    b.HasIndex("ID_IPAddress");

                    b.HasIndex("ID_User");

                    b.ToTable("RentalContract ");
                });

            modelBuilder.Entity("IPAddressManagement.Models.User", b =>
                {
                    b.Property<int>("ID_User")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_User"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ID_Group")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID_User");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("ID_Group");

                    b.ToTable("User");
                });

            modelBuilder.Entity("IPAddressManagement.Models.RentalContract", b =>
                {
                    b.HasOne("IPAddressManagement.Models.Customer", "Customer")
                        .WithMany("RentalContracts")
                        .HasForeignKey("ID_Customer");

                    b.HasOne("IPAddressManagement.Models.IPAddresss", "IPAddresss")
                        .WithMany("RentalContracts")
                        .HasForeignKey("ID_IPAddress");

                    b.HasOne("IPAddressManagement.Models.User", "User")
                        .WithMany("RentalContracts")
                        .HasForeignKey("ID_User");

                    b.Navigation("Customer");

                    b.Navigation("IPAddresss");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IPAddressManagement.Models.User", b =>
                {
                    b.HasOne("IPAddressManagement.Models.GroupUser", "Group")
                        .WithMany("Users")
                        .HasForeignKey("ID_Group");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("IPAddressManagement.Models.Customer", b =>
                {
                    b.Navigation("RentalContracts");
                });

            modelBuilder.Entity("IPAddressManagement.Models.GroupUser", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("IPAddressManagement.Models.IPAddresss", b =>
                {
                    b.Navigation("RentalContracts");
                });

            modelBuilder.Entity("IPAddressManagement.Models.User", b =>
                {
                    b.Navigation("RentalContracts");
                });
#pragma warning restore 612, 618
        }
    }
}