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
    [Migration("20250301222413_relations")]
    partial class relations
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

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Schedule")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
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

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("LeaveRequestID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Leaves");
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
