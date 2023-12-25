﻿// <auto-generated />
using System;
using MainProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MainProject.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("AccountEmployeeEmployeeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
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

                    b.Property<string>("BookingGuestGuestID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("BookingRoomRoomID")
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
                    b.Property<string>("EmployeeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmplooyeeEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeFacilityFacilityID")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("EmployeeSalary")
                        .HasColumnType("float");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<double>("WorkingHours")
                        .HasColumnType("float");

                    b.HasKey("EmployeeID");

                    b.HasIndex("EmployeeFacilityFacilityID");

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

                    b.Property<int?>("EventFacilityFacilityID")
                        .HasColumnType("int");

                    b.Property<double>("EventFee")
                        .HasColumnType("float");

                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventStart")
                        .HasColumnType("datetime");

                    b.Property<string>("EventType")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FacilityWorkEnd")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FacilityWorkStart")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("FacilityID");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("MainProject.Models.Guest", b =>
                {
                    b.Property<string>("GuestID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GuestName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuestNationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuestPhoneNumber")
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomType")
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TransactionFee")
                        .HasColumnType("float");

                    b.Property<int?>("TransactionRoomRoomID")
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
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("AccountEmployee");
                });

            modelBuilder.Entity("MainProject.Models.Booking", b =>
                {
                    b.HasOne("MainProject.Models.Guest", "BookingGuest")
                        .WithMany("GuestBookings")
                        .HasForeignKey("BookingGuestGuestID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MainProject.Models.Room", "BookingRoom")
                        .WithMany("RoomBookings")
                        .HasForeignKey("BookingRoomRoomID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("BookingGuest");

                    b.Navigation("BookingRoom");
                });

            modelBuilder.Entity("MainProject.Models.Employee", b =>
                {
                    b.HasOne("MainProject.Models.Facility", "EmployeeFacility")
                        .WithMany("FacilityEmployee")
                        .HasForeignKey("EmployeeFacilityFacilityID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("EmployeeFacility");
                });

            modelBuilder.Entity("MainProject.Models.Event", b =>
                {
                    b.HasOne("MainProject.Models.Facility", "EventFacility")
                        .WithMany("FacilityEvent")
                        .HasForeignKey("EventFacilityFacilityID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("EventFacility");
                });

            modelBuilder.Entity("MainProject.Models.Transaction", b =>
                {
                    b.HasOne("MainProject.Models.Room", "TransactionRoom")
                        .WithMany("RoomTransactionts")
                        .HasForeignKey("TransactionRoomRoomID")
                        .OnDelete(DeleteBehavior.Cascade);

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
