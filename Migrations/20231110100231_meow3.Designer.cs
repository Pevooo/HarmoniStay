﻿// <auto-generated />
using System;
using MainProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MainProject.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231110100231_meow3")]
    partial class meow3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MainProject.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountID"));

                    b.Property<int>("AccountEmloyeeEmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountID");

                    b.HasIndex("AccountEmloyeeEmployeeID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("MainProject.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("EmployeeSalary")
                        .HasColumnType("float");

                    b.Property<int>("FacilityEmployeeFacilityID")
                        .HasColumnType("int");

                    b.Property<double>("WorkingHours")
                        .HasColumnType("float");

                    b.HasKey("EmployeeID");

                    b.HasIndex("FacilityEmployeeFacilityID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MainProject.Event", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventID"));

                    b.Property<DateTime>("EventEnd")
                        .HasColumnType("datetime");

                    b.Property<int>("EventFacilityFacilityID")
                        .HasColumnType("int");

                    b.Property<double>("EventFee")
                        .HasColumnType("float");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventStart")
                        .HasColumnType("datetime");

                    b.HasKey("EventID");

                    b.HasIndex("EventFacilityFacilityID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("MainProject.Facility", b =>
                {
                    b.Property<int>("FacilityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacilityID"));

                    b.Property<string>("FacilityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FacilityWorkEnd")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FacilityWorkStart")
                        .HasColumnType("datetime");

                    b.HasKey("FacilityID");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("MainProject.Guest", b =>
                {
                    b.Property<int>("GuestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GuestID"));

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime");

                    b.Property<string>("GuestName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GuestRoomRoomID")
                        .HasColumnType("int");

                    b.Property<string>("GustRoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GuestID");

                    b.HasIndex("GuestRoomRoomID");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("MainProject.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomID"));

                    b.Property<int>("RoomBuildingNumber")
                        .HasColumnType("int");

                    b.Property<string>("RoomCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("MainProject.Transaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionID"));

                    b.Property<string>("TransactionDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TransactionFee")
                        .HasColumnType("float");

                    b.Property<int>("TransactionRoomRoomID")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionTime")
                        .HasColumnType("datetime");

                    b.HasKey("TransactionID");

                    b.HasIndex("TransactionRoomRoomID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("MainProject.Account", b =>
                {
                    b.HasOne("MainProject.Employee", "AccountEmloyee")
                        .WithMany()
                        .HasForeignKey("AccountEmloyeeEmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountEmloyee");
                });

            modelBuilder.Entity("MainProject.Employee", b =>
                {
                    b.HasOne("MainProject.Facility", "FacilityEmployee")
                        .WithMany("FacilityEmployee")
                        .HasForeignKey("FacilityEmployeeFacilityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FacilityEmployee");
                });

            modelBuilder.Entity("MainProject.Event", b =>
                {
                    b.HasOne("MainProject.Facility", "EventFacility")
                        .WithMany("FacilityEvent")
                        .HasForeignKey("EventFacilityFacilityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventFacility");
                });

            modelBuilder.Entity("MainProject.Guest", b =>
                {
                    b.HasOne("MainProject.Room", "GuestRoom")
                        .WithMany("RoomGuests")
                        .HasForeignKey("GuestRoomRoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GuestRoom");
                });

            modelBuilder.Entity("MainProject.Transaction", b =>
                {
                    b.HasOne("MainProject.Room", "TransactionRoom")
                        .WithMany("RoomTransactionts")
                        .HasForeignKey("TransactionRoomRoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TransactionRoom");
                });

            modelBuilder.Entity("MainProject.Facility", b =>
                {
                    b.Navigation("FacilityEmployee");

                    b.Navigation("FacilityEvent");
                });

            modelBuilder.Entity("MainProject.Room", b =>
                {
                    b.Navigation("RoomGuests");

                    b.Navigation("RoomTransactionts");
                });
#pragma warning restore 612, 618
        }
    }
}
