﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

namespace Repositories.Migrations
{
    [DbContext(typeof(WickedAirSourceContextDupe))]
    [Migration("20201020000146_InitialNew")]
    partial class InitialNew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("syntra")
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("Models.Models.AircraftType", b =>
                {
                    b.Property<byte>("TypeId")
                        .HasColumnType("tinyint")
                        .HasColumnName("TypeID");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.ToTable("AircraftType", "dbo");
                });

            modelBuilder.Entity("Models.Models.AircraftTypeDetail", b =>
                {
                    b.Property<byte>("AircraftTypeId")
                        .HasColumnType("tinyint")
                        .HasColumnName("AircraftTypeID");

                    b.Property<float?>("Length")
                        .HasColumnType("real");

                    b.Property<string>("Memo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("Tare")
                        .HasColumnType("smallint");

                    b.Property<byte?>("TurbineCount")
                        .HasColumnType("tinyint");

                    b.HasKey("AircraftTypeId");

                    b.ToTable("AircraftTypeDetail", "dbo");
                });

            modelBuilder.Entity("Models.Models.Airline", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("Bunkrupt")
                        .HasColumnType("bit");

                    b.Property<int?>("FoundingYear")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Code");

                    b.ToTable("Airline", "dbo");
                });

            modelBuilder.Entity("Models.Models.Booking", b =>
                {
                    b.Property<int>("FlightNo")
                        .HasColumnType("int");

                    b.Property<int>("PassengerId")
                        .HasColumnType("int")
                        .HasColumnName("PassengerID");

                    b.HasKey("FlightNo", "PassengerId");

                    b.HasIndex(new[] { "PassengerId" }, "IX_Booking_PassengerID");

                    b.ToTable("Booking", "dbo");
                });

            modelBuilder.Entity("Models.Models.DepartureGrouping", b =>
                {
                    b.Property<string>("Departure")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("FlightCount")
                        .HasColumnType("int");

                    b.HasKey("Departure");

                    b.ToTable("DepartureGrouping", "dbo");
                });

            modelBuilder.Entity("Models.Models.Employee", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PersonID")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DetailId")
                        .HasColumnType("int")
                        .HasColumnName("DetailID");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EMail");

                    b.Property<int?>("FlightHours")
                        .HasColumnType("int");

                    b.Property<string>("FlightSchool")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GivenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LicenseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PassportNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PilotLicenseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.Property<int?>("SupervisorPersonId")
                        .HasColumnType("int")
                        .HasColumnName("SupervisorPersonID");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.HasIndex(new[] { "DetailId" }, "IX_Employee_DetailID");

                    b.HasIndex(new[] { "SupervisorPersonId" }, "IX_Employee_SupervisorPersonID");

                    b.ToTable("Employee", "dbo");
                });

            modelBuilder.Entity("Models.Models.Flight", b =>
                {
                    b.Property<int>("FlightNo")
                        .HasColumnType("int");

                    b.Property<byte?>("AircraftTypeId")
                        .HasColumnType("tinyint")
                        .HasColumnName("AircraftTypeID");

                    b.Property<string>("AirlineCode")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<int?>("CopilotId")
                        .HasColumnType("int");

                    b.Property<string>("Departure")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("(N'(not set)')");

                    b.Property<string>("Destination")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValueSql("(N'(not set)')");

                    b.Property<DateTime>("FlightDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<short?>("FreeSeats")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("LastChange")
                        .HasColumnType("datetime2");

                    b.Property<string>("Memo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("NonSmokingFlight")
                        .HasColumnType("bit");

                    b.Property<int>("PilotId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValueSql("((123.45))");

                    b.Property<short>("Seats")
                        .HasColumnType("smallint");

                    b.Property<bool?>("Strikebound")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<decimal?>("Utilization")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("numeric(20,8)")
                        .HasComputedColumnSql("((100.0)-(([FreeSeats]*(1.0))/[Seats])*(100.0))", false);

                    b.HasKey("FlightNo");

                    b.HasIndex(new[] { "AircraftTypeId" }, "IX_Flight_AircraftTypeID");

                    b.HasIndex(new[] { "AirlineCode" }, "IX_Flight_AirlineCode");

                    b.HasIndex(new[] { "CopilotId" }, "IX_Flight_CopilotId");

                    b.HasIndex(new[] { "Departure", "Destination" }, "IX_Flight_Departure_Destination");

                    b.HasIndex(new[] { "PilotId" }, "IX_Flight_PilotId");

                    b.HasIndex(new[] { "FreeSeats" }, "Index_FreeSeats");

                    b.ToTable("Flight", "dbo");
                });

            modelBuilder.Entity("Models.Models.Passenger", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PersonID")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CustomerSince")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DetailId")
                        .HasColumnType("int")
                        .HasColumnName("DetailID");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EMail");

                    b.Property<bool?>("FrequentFlyer")
                        .HasColumnType("bit");

                    b.Property<string>("GivenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.HasIndex(new[] { "DetailId" }, "IX_Passenger_DetailID");

                    b.ToTable("Passenger", "dbo");
                });

            modelBuilder.Entity("Models.Models.Persondetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .UseIdentityColumn();

                    b.Property<string>("City")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Country")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Memo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Planet")
                        .HasMaxLength(130)
                        .HasColumnType("nvarchar(130)");

                    b.Property<string>("Postcode")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Street")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Persondetail", "dbo");
                });

            modelBuilder.Entity("Models.Models.VDepartureStatistic", b =>
                {
                    b.Property<string>("Departure")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("FlightCount")
                        .HasColumnType("int");

                    b.HasKey("Departure");

                    b.ToTable("V_DepartureStatistics", "dbo");
                });

            modelBuilder.Entity("Models.Models.AircraftTypeDetail", b =>
                {
                    b.HasOne("Models.Models.AircraftType", "AircraftType")
                        .WithOne("AircraftTypeDetail")
                        .HasForeignKey("Models.Models.AircraftTypeDetail", "AircraftTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AircraftType");
                });

            modelBuilder.Entity("Models.Models.Booking", b =>
                {
                    b.HasOne("Models.Models.Flight", "FlightNoNavigation")
                        .WithMany("Bookings")
                        .HasForeignKey("FlightNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Models.Passenger", "Passenger")
                        .WithMany("Bookings")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FlightNoNavigation");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("Models.Models.Employee", b =>
                {
                    b.HasOne("Models.Models.Persondetail", "Detail")
                        .WithMany("Employees")
                        .HasForeignKey("DetailId");

                    b.HasOne("Models.Models.Employee", "SupervisorPerson")
                        .WithMany("InverseSupervisorPerson")
                        .HasForeignKey("SupervisorPersonId");

                    b.Navigation("Detail");

                    b.Navigation("SupervisorPerson");
                });

            modelBuilder.Entity("Models.Models.Flight", b =>
                {
                    b.HasOne("Models.Models.AircraftType", "AircraftType")
                        .WithMany("Flights")
                        .HasForeignKey("AircraftTypeId");

                    b.HasOne("Models.Models.Airline", "AirlineCodeNavigation")
                        .WithMany("Flights")
                        .HasForeignKey("AirlineCode");

                    b.HasOne("Models.Models.Employee", "Copilot")
                        .WithMany("FlightCopilots")
                        .HasForeignKey("CopilotId");

                    b.HasOne("Models.Models.Employee", "Pilot")
                        .WithMany("FlightPilots")
                        .HasForeignKey("PilotId")
                        .IsRequired();

                    b.Navigation("AircraftType");

                    b.Navigation("AirlineCodeNavigation");

                    b.Navigation("Copilot");

                    b.Navigation("Pilot");
                });

            modelBuilder.Entity("Models.Models.Passenger", b =>
                {
                    b.HasOne("Models.Models.Persondetail", "Detail")
                        .WithMany("Passengers")
                        .HasForeignKey("DetailId");

                    b.Navigation("Detail");
                });

            modelBuilder.Entity("Models.Models.AircraftType", b =>
                {
                    b.Navigation("AircraftTypeDetail");

                    b.Navigation("Flights");
                });

            modelBuilder.Entity("Models.Models.Airline", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("Models.Models.Employee", b =>
                {
                    b.Navigation("FlightCopilots");

                    b.Navigation("FlightPilots");

                    b.Navigation("InverseSupervisorPerson");
                });

            modelBuilder.Entity("Models.Models.Flight", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Models.Models.Passenger", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Models.Models.Persondetail", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Passengers");
                });
#pragma warning restore 612, 618
        }
    }
}
