﻿// <auto-generated />
using System;
using Attendance_Management.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Attendance_Management.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20250306234252_lastupdatedata3")]
    partial class lastupdatedata3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Attendance_Management.Models.Attendance", b =>
                {
                    b.Property<int>("AttendanceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AttendanceID"));

                    b.Property<DateTime?>("CheckInTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CheckOutTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EarlyDeparture")
                        .HasColumnType("bit");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<bool>("LateArrival")
                        .HasColumnType("bit");

                    b.HasKey("AttendanceID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Attendances");

                    b.HasData(
                        new
                        {
                            AttendanceID = 1,
                            CheckInTime = new DateTime(2025, 3, 1, 8, 55, 0, 0, DateTimeKind.Unspecified),
                            CheckOutTime = new DateTime(2025, 3, 1, 17, 5, 0, 0, DateTimeKind.Unspecified),
                            EarlyDeparture = false,
                            EmployeeID = 1,
                            LateArrival = true
                        },
                        new
                        {
                            AttendanceID = 2,
                            CheckInTime = new DateTime(2025, 3, 2, 9, 10, 0, 0, DateTimeKind.Unspecified),
                            CheckOutTime = new DateTime(2025, 3, 2, 16, 50, 0, 0, DateTimeKind.Unspecified),
                            EarlyDeparture = false,
                            EmployeeID = 2,
                            LateArrival = true
                        },
                        new
                        {
                            AttendanceID = 3,
                            CheckInTime = new DateTime(2025, 3, 3, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            CheckOutTime = new DateTime(2025, 3, 3, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            EarlyDeparture = false,
                            EmployeeID = 3,
                            LateArrival = false
                        },
                        new
                        {
                            AttendanceID = 4,
                            CheckInTime = new DateTime(2025, 3, 4, 8, 45, 0, 0, DateTimeKind.Unspecified),
                            CheckOutTime = new DateTime(2025, 3, 4, 16, 40, 0, 0, DateTimeKind.Unspecified),
                            EarlyDeparture = true,
                            EmployeeID = 4,
                            LateArrival = true
                        },
                        new
                        {
                            AttendanceID = 5,
                            CheckInTime = new DateTime(2025, 3, 5, 9, 5, 0, 0, DateTimeKind.Unspecified),
                            CheckOutTime = new DateTime(2025, 3, 5, 16, 55, 0, 0, DateTimeKind.Unspecified),
                            EarlyDeparture = false,
                            EmployeeID = 5,
                            LateArrival = true
                        },
                        new
                        {
                            AttendanceID = 6,
                            CheckInTime = new DateTime(2025, 3, 6, 8, 50, 0, 0, DateTimeKind.Unspecified),
                            CheckOutTime = new DateTime(2025, 3, 6, 17, 10, 0, 0, DateTimeKind.Unspecified),
                            EarlyDeparture = false,
                            EmployeeID = 1,
                            LateArrival = true
                        },
                        new
                        {
                            AttendanceID = 7,
                            CheckInTime = new DateTime(2025, 3, 7, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOutTime = new DateTime(2025, 3, 7, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            EarlyDeparture = true,
                            EmployeeID = 2,
                            LateArrival = false
                        },
                        new
                        {
                            AttendanceID = 8,
                            CheckInTime = new DateTime(2025, 3, 8, 9, 30, 0, 0, DateTimeKind.Unspecified),
                            CheckOutTime = new DateTime(2025, 3, 8, 17, 15, 0, 0, DateTimeKind.Unspecified),
                            EarlyDeparture = false,
                            EmployeeID = 3,
                            LateArrival = true
                        },
                        new
                        {
                            AttendanceID = 9,
                            CheckInTime = new DateTime(2025, 3, 9, 8, 15, 0, 0, DateTimeKind.Unspecified),
                            CheckOutTime = new DateTime(2025, 3, 9, 16, 45, 0, 0, DateTimeKind.Unspecified),
                            EarlyDeparture = true,
                            EmployeeID = 4,
                            LateArrival = false
                        },
                        new
                        {
                            AttendanceID = 10,
                            CheckInTime = new DateTime(2025, 3, 10, 8, 40, 0, 0, DateTimeKind.Unspecified),
                            CheckOutTime = new DateTime(2025, 3, 10, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            EarlyDeparture = false,
                            EmployeeID = 5,
                            LateArrival = true
                        });
                });

            modelBuilder.Entity("Attendance_Management.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Schedule")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            Department = "HR",
                            Email = "alice.johnson@company.com",
                            Name = "Alice Johnson",
                            Password = "hashedpass1",
                            Phone = "0123456789",
                            Role = 0,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 2,
                            Department = "Sales",
                            Email = "bob.smith@company.com",
                            Name = "Bob Smith",
                            Password = "hashedpass2",
                            Phone = "0987654321",
                            Role = 2,
                            Schedule = 2
                        },
                        new
                        {
                            EmployeeID = 3,
                            Department = "HR",
                            Email = "charlie.brown@company.com",
                            Name = "Charlie Brown",
                            Password = "hashedpass3",
                            Phone = "0543216789",
                            Role = 1,
                            Schedule = 1
                        },
                        new
                        {
                            EmployeeID = 4,
                            Department = "HR",
                            Email = "diana.green@company.com",
                            Name = "Diana Green",
                            Password = "hashedpass4",
                            Phone = "0778899000",
                            Role = 2,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 5,
                            Department = "HR",
                            Email = "ethan.white@company.com",
                            Name = "Ethan White",
                            Password = "hashedpass5",
                            Phone = "0667788990",
                            Role = 2,
                            Schedule = 1
                        },
                        new
                        {
                            EmployeeID = 6,
                            Department = "IT",
                            Email = "aml@company.com",
                            Name = "AML",
                            Password = "123",
                            Phone = "0667788990",
                            Role = 2,
                            Schedule = 1
                        },
                        new
                        {
                            EmployeeID = 7,
                            Department = "IT",
                            Email = "eman@gmail.com",
                            Name = "eman",
                            Password = "123",
                            Phone = "1111111",
                            Role = 2,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 8,
                            Department = "IT",
                            Email = "esraa@gmail.com",
                            Name = "esraa",
                            Password = "123",
                            Phone = "1111111",
                            Role = 2,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 9,
                            Department = "Marketing",
                            Email = "yasser@gmail.com",
                            Name = "yasser",
                            Password = "55555",
                            Phone = "1111111",
                            Role = 2,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 10,
                            Department = "Marketing",
                            Email = "fa@gmail.com",
                            Name = "fatma",
                            Password = "111",
                            Phone = "1111111",
                            Role = 2,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 11,
                            Department = "Marketing",
                            Email = "sara@gmail.com",
                            Name = "sara",
                            Password = "111",
                            Phone = "1111111",
                            Role = 2,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 12,
                            Department = "Marketing",
                            Email = "a@gmail.com",
                            Name = "a",
                            Password = "111",
                            Phone = "1111111",
                            Role = 2,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 13,
                            Department = "Operations",
                            Email = "b@gmail.com",
                            Name = "b",
                            Password = "111",
                            Phone = "1111111",
                            Role = 2,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 14,
                            Department = "Operations",
                            Email = "c@gmail.com",
                            Name = "c",
                            Password = "111",
                            Phone = "1111111",
                            Role = 2,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 15,
                            Department = "Operations",
                            Email = "d@gmail.com",
                            Name = "d",
                            Password = "111",
                            Phone = "1111111",
                            Role = 2,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 16,
                            Department = "Operations",
                            Email = "new@gmail.com",
                            Name = "new",
                            Password = "111",
                            Phone = "1111111",
                            Role = 2,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 17,
                            Department = "Operations",
                            Email = "n@gmail.com",
                            Name = "n",
                            Password = "111",
                            Phone = "1111111",
                            Role = 2,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 18,
                            Department = "Operations",
                            Email = "last@gmail.com",
                            Name = "last",
                            Password = "111",
                            Phone = "1111111",
                            Role = 2,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 19,
                            Department = "Operations",
                            Email = "last1@gmail.com",
                            Name = "last1",
                            Password = "111",
                            Phone = "1111111",
                            Role = 2,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 20,
                            Department = "Operations",
                            Email = "last2@gmail.com",
                            Name = "last2",
                            Password = "111",
                            Phone = "1111111",
                            Role = 2,
                            Schedule = 0
                        },
                        new
                        {
                            EmployeeID = 21,
                            Department = "Operations",
                            Email = "last3@gmail.com",
                            Name = "last3",
                            Password = "111",
                            Phone = "1111111",
                            Role = 2,
                            Schedule = 0
                        });
                });

            modelBuilder.Entity("Attendance_Management.Models.LeaveRequest", b =>
                {
                    b.Property<int>("LeaveRequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeaveRequestID"));

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("LeaveRequestID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Leaves");

                    b.HasData(
                        new
                        {
                            LeaveRequestID = 1,
                            EmployeeID = 2,
                            EndDate = new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Reason = "Not specified",
                            StartDate = new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            Type = 1
                        },
                        new
                        {
                            LeaveRequestID = 2,
                            EmployeeID = 3,
                            EndDate = new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Reason = "Not specified",
                            StartDate = new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0,
                            Type = 0
                        },
                        new
                        {
                            LeaveRequestID = 3,
                            EmployeeID = 5,
                            EndDate = new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Reason = "Not specified",
                            StartDate = new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 2,
                            Type = 2
                        },
                        new
                        {
                            LeaveRequestID = 4,
                            EmployeeID = 1,
                            EndDate = new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Reason = "Not specified",
                            StartDate = new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            Type = 1
                        },
                        new
                        {
                            LeaveRequestID = 5,
                            EmployeeID = 4,
                            EndDate = new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Reason = "Not specified",
                            StartDate = new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0,
                            Type = 0
                        },
                        new
                        {
                            LeaveRequestID = 6,
                            EmployeeID = 3,
                            EndDate = new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Reason = "Not specified",
                            StartDate = new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            Type = 2
                        });
                });

            modelBuilder.Entity("Attendance_Management.Models.Attendance", b =>
                {
                    b.HasOne("Attendance_Management.Models.Employee", "Employee")
                        .WithMany("Attendances")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Attendance_Management.Models.LeaveRequest", b =>
                {
                    b.HasOne("Attendance_Management.Models.Employee", "Employee")
                        .WithMany("Leaves")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Attendance_Management.Models.Employee", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("Leaves");
                });
#pragma warning restore 612, 618
        }
    }
}
