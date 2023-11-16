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
    [Migration("20231116072836_AllFixed")]
    partial class AllFixed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MainProject.Models.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountID"));

                    b.Property<int>("AccountEmployeeEmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountID");

                    b.HasIndex("AccountEmployeeEmployeeID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("MainProject.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<int>("BookingGuestGuestID")
                        .HasColumnType("int");

                    b.Property<int>("BookingRoomRoomID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime");

                    b.HasKey("BookingID");

                    b.HasIndex("BookingGuestGuestID");

                    b.HasIndex("BookingRoomRoomID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("MainProject.Models.Employee", b =>
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

            modelBuilder.Entity("MainProject.Models.Event", b =>
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

            modelBuilder.Entity("MainProject.Models.Facility", b =>
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

            modelBuilder.Entity("MainProject.Models.Guest", b =>
                {
                    b.Property<int>("GuestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GuestID"));

                    b.Property<string>("GuestName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuestNationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuestPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GuestID");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("MainProject.Models.Room", b =>
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

            modelBuilder.Entity("MainProject.Models.Transaction", b =>
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

            modelBuilder.Entity("MainProject.Models.Account", b =>
                {
                    b.HasOne("MainProject.Models.Employee", "AccountEmployee")
                        .WithMany()
                        .HasForeignKey("AccountEmployeeEmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountEmployee");
                });

            modelBuilder.Entity("MainProject.Models.Booking", b =>
                {
                    b.HasOne("MainProject.Models.Guest", "BookingGuest")
                        .WithMany("GuestBookings")
                        .HasForeignKey("BookingGuestGuestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MainProject.Models.Room", "BookingRoom")
                        .WithMany("RoomBookings")
                        .HasForeignKey("BookingRoomRoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookingGuest");

                    b.Navigation("BookingRoom");
                });

            modelBuilder.Entity("MainProject.Models.Employee", b =>
                {
                    b.HasOne("MainProject.Models.Facility", "FacilityEmployee")
                        .WithMany("FacilityEmployee")
                        .HasForeignKey("FacilityEmployeeFacilityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FacilityEmployee");
                });

            modelBuilder.Entity("MainProject.Models.Event", b =>
                {
                    b.HasOne("MainProject.Models.Facility", "EventFacility")
                        .WithMany("FacilityEvent")
                        .HasForeignKey("EventFacilityFacilityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventFacility");
                });

            modelBuilder.Entity("MainProject.Models.Transaction", b =>
                {
                    b.HasOne("MainProject.Models.Room", "TransactionRoom")
                        .WithMany("RoomTransactionts")
                        .HasForeignKey("TransactionRoomRoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TransactionRoom");
                });

            modelBuilder.Entity("MainProject.Models.Facility", b =>
                {
                    b.Navigation("FacilityEmployee");

                    b.Navigation("FacilityEvent");
                });

            modelBuilder.Entity("MainProject.Models.Guest", b =>
                {
                    b.Navigation("GuestBookings");
                });

            modelBuilder.Entity("MainProject.Models.Room", b =>
                {
                    b.Navigation("RoomBookings");

                    b.Navigation("RoomTransactionts");
                });
#pragma warning restore 612, 618
        }
    }
}
