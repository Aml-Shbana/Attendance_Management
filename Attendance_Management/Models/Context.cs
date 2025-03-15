using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management.Models
{
    public class Context : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<LeaveRequest> Leaves { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; database = Attendance_Management; Trusted_Connection = True; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>().HasOne(e => e.Employee).WithMany(e => e.Attendances).HasForeignKey(e => e.EmployeeID);
            modelBuilder.Entity<LeaveRequest>().HasOne(e => e.Employee).WithMany(e => e.Leaves).HasForeignKey(e => e.EmployeeID);
            modelBuilder.Entity<Logs>().HasOne(e => e.Employee).WithMany(e => e.Logs).HasForeignKey(e =>e.EmployeeID);

            modelBuilder.Entity<Employee>().Property(e => e.Department).HasConversion<string>();

            modelBuilder.Entity<Employee>().HasData(
            new Employee { EmployeeID = 1, Name = "Alice Johnson", Department = Department.IT, Role = UserRole.Admin, Email = "alice.johnson@company.com", Phone = "0123456789", Schedule = WorkSchedule.FullTime, Password = "hashedpass1" },
            new Employee { EmployeeID = 2, Name = "Bob Smith", Department = Department.HR, Role = UserRole.Employee, Email = "bob.smith@company.com", Phone = "0987654321", Schedule = WorkSchedule.Remote, Password = "hashedpass2" },
            new Employee { EmployeeID = 3, Name = "Charlie Brown", Department = Department.Finance, Role = UserRole.HR, Email = "charlie.brown@company.com", Phone = "0543216789", Schedule = WorkSchedule.PartTime, Password = "hashedpass3" },
            new Employee { EmployeeID = 4, Name = "Diana Green", Department = Department.IT, Role = UserRole.Employee, Email = "diana.green@company.com", Phone = "0778899000", Schedule = WorkSchedule.FullTime, Password = "hashedpass4" },
            new Employee { EmployeeID = 5, Name = "Ethan White", Department = Department.Marketing, Role = UserRole.Employee, Email = "ethan.white@company.com", Phone = "0667788990", Schedule = WorkSchedule.PartTime, Password = "hashedpass5" },
            new Employee { EmployeeID = 6, Name = "AML", Department = Department.Marketing, Role = UserRole.Employee, Email = "aml@company.com", Phone = "0667788990", Schedule = WorkSchedule.PartTime, Password = "123" },
            new Employee { EmployeeID = 7, Name = "Fatma", Department = Department.HR, Role = UserRole.HR, Email = "fatma@company.com", Phone = "0667788990", Schedule = WorkSchedule.PartTime, Password = "123" },
            new Employee { EmployeeID = 8, Name = "new", Department = Department.HR, Role = UserRole.HR, Email = "new@company.com", Phone = "0667788990", Schedule = WorkSchedule.PartTime, Password = "123" },
            new Employee { EmployeeID = 9, Name = "emp", Department = Department.Marketing, Role = UserRole.Employee, Email = "emp@company.com", Phone = "0667788990", Schedule = WorkSchedule.PartTime, Password = "123" },
            new Employee { EmployeeID = 10, Name = "Aml Shbana", Department = Department.Marketing, Role = UserRole.Employee, Email = "amlshbana28@gmail.com", Phone = "01008314776", Schedule = WorkSchedule.PartTime, Password = "123" },
            new Employee { EmployeeID = 11, Name = "alaa", Department = Department.Marketing, Role = UserRole.Employee, Email = "alaa@gmail.com", Phone = "01008314776", Schedule = WorkSchedule.PartTime, Password = "123" },
            new Employee { EmployeeID = 12, Name = "ahmed", Department = Department.Marketing, Role = UserRole.Employee, Email = "ahmed@gmail.com", Phone = "01008314776", Schedule = WorkSchedule.PartTime, Password = "123" },
            new Employee { EmployeeID = 13, Name = "yasser", Department = Department.Marketing, Role = UserRole.Employee, Email = "yasser@gmail.com", Phone = "01008314776", Schedule = WorkSchedule.PartTime, Password = "123" },
            new Employee { EmployeeID = 14, Name = "mohamed", Department = Department.Marketing, Role = UserRole.Employee, Email = "mohamed@gmail.com", Phone = "01008314776", Schedule = WorkSchedule.PartTime, Password = "123" });



            // Seed Leaves
            modelBuilder.Entity<LeaveRequest>().HasData(
                new LeaveRequest { LeaveRequestID = 1, StartDate = DateTime.Parse("2025-03-05"), EndDate = DateTime.Parse("2025-03-10"), Status = LeaveStatus.Approved, Type = LeaveType.Vacation, Reason = "Not specified", EmployeeID = 2 },
                new LeaveRequest { LeaveRequestID = 2, StartDate = DateTime.Parse("2025-03-15"), EndDate = DateTime.Parse("2025-03-16"), Status = LeaveStatus.Pending, Type = LeaveType.SickLeave, Reason = "Not specified", EmployeeID = 3 },
                new LeaveRequest { LeaveRequestID = 3, StartDate = DateTime.Parse("2025-04-01"), EndDate = DateTime.Parse("2025-04-15"), Status = LeaveStatus.Rejected, Type = LeaveType.UnpaidLeave, Reason = "Not specified", EmployeeID = 5 },
                new LeaveRequest { LeaveRequestID = 4, StartDate = DateTime.Parse("2025-04-10"), EndDate = DateTime.Parse("2025-04-20"), Status = LeaveStatus.Approved, Type = LeaveType.Vacation, Reason = "Not specified", EmployeeID = 1 },
                new LeaveRequest { LeaveRequestID = 5, StartDate = DateTime.Parse("2025-05-02"), EndDate = DateTime.Parse("2025-05-05"), Status = LeaveStatus.Pending, Type = LeaveType.SickLeave, Reason = "Not specified", EmployeeID = 4 },
                new LeaveRequest { LeaveRequestID = 6, StartDate = DateTime.Parse("2025-05-15"), EndDate = DateTime.Parse("2025-05-25"), Status = LeaveStatus.Approved, Type = LeaveType.UnpaidLeave, Reason = "Not specified", EmployeeID = 3 }
            );

            // Seed Attendances
            modelBuilder.Entity<Attendance>().HasData(
                new Attendance { AttendanceID = 1, CheckInTime = DateTime.Parse("2025-03-01 08:55:00"), CheckOutTime = DateTime.Parse("2025-03-01 17:05:00"), LateArrival = true, EarlyDeparture = false, EmployeeID = 1 },
                new Attendance { AttendanceID = 2, CheckInTime = DateTime.Parse("2025-03-02 09:10:00"), CheckOutTime = DateTime.Parse("2025-03-02 16:50:00"), LateArrival = true, EarlyDeparture = false, EmployeeID = 2 },
                new Attendance { AttendanceID = 3, CheckInTime = DateTime.Parse("2025-03-03 08:30:00"), CheckOutTime = DateTime.Parse("2025-03-03 17:00:00"), LateArrival = false, EarlyDeparture = false, EmployeeID = 3 },
                new Attendance { AttendanceID = 4, CheckInTime = DateTime.Parse("2025-03-04 08:45:00"), CheckOutTime = DateTime.Parse("2025-03-04 16:40:00"), LateArrival = true, EarlyDeparture = true, EmployeeID = 4 },
                new Attendance { AttendanceID = 5, CheckInTime = DateTime.Parse("2025-03-05 09:05:00"), CheckOutTime = DateTime.Parse("2025-03-05 16:55:00"), LateArrival = true, EarlyDeparture = false, EmployeeID = 5 },
                new Attendance { AttendanceID = 6, CheckInTime = DateTime.Parse("2025-03-06 08:50:00"), CheckOutTime = DateTime.Parse("2025-03-06 17:10:00"), LateArrival = true, EarlyDeparture = false, EmployeeID = 1 },
                new Attendance { AttendanceID = 7, CheckInTime = DateTime.Parse("2025-03-07 08:00:00"), CheckOutTime = DateTime.Parse("2025-03-07 16:30:00"), LateArrival = false, EarlyDeparture = true, EmployeeID = 2 },
                new Attendance { AttendanceID = 8, CheckInTime = DateTime.Parse("2025-03-08 09:30:00"), CheckOutTime = DateTime.Parse("2025-03-08 17:15:00"), LateArrival = true, EarlyDeparture = false, EmployeeID = 3 },
                new Attendance { AttendanceID = 9, CheckInTime = DateTime.Parse("2025-03-09 08:15:00"), CheckOutTime = DateTime.Parse("2025-03-09 16:45:00"), LateArrival = false, EarlyDeparture = true, EmployeeID = 4 },
                new Attendance { AttendanceID = 10, CheckInTime = DateTime.Parse("2025-03-10 08:40:00"), CheckOutTime = DateTime.Parse("2025-03-10 17:00:00"), LateArrival = true, EarlyDeparture = false, EmployeeID = 5 }
            );

            //logs 
            modelBuilder.Entity<Logs>().HasData(
                new Logs { LogId = 1, EmployeeID = 1, Action = Action_Type.check_in, Time_OfAction = new DateTime(2025, 3, 1, 8, 55, 0) },
                new Logs { LogId = 2, EmployeeID = 1, Action = Action_Type.check_out, Time_OfAction = new DateTime(2025, 3, 1, 17, 5, 0) },
                new Logs { LogId = 3, EmployeeID = 2, Action = Action_Type.check_in, Time_OfAction = new DateTime(2025, 3, 2, 9, 10, 0) },
                new Logs { LogId = 4, EmployeeID = 2, Action = Action_Type.check_out, Time_OfAction = new DateTime(2025, 3, 2, 16, 50, 0) },
                new Logs { LogId = 5, EmployeeID = 3, Action = Action_Type.check_in, Time_OfAction = new DateTime(2025, 3, 3, 8, 30, 0) },
                new Logs { LogId = 6, EmployeeID = 3, Action = Action_Type.check_out, Time_OfAction = new DateTime(2025, 3, 3, 17, 0, 0) },
                new Logs { LogId = 7, EmployeeID = 4, Action = Action_Type.check_in, Time_OfAction = new DateTime(2025, 3, 4, 8, 45, 0) },
                new Logs { LogId = 8, EmployeeID = 4, Action = Action_Type.check_out, Time_OfAction = new DateTime(2025, 3, 4, 16, 40, 0) },
                new Logs { LogId = 9, EmployeeID = 5, Action = Action_Type.check_in, Time_OfAction = new DateTime(2025, 3, 5, 9, 5, 0) },
                new Logs { LogId = 10, EmployeeID = 5, Action = Action_Type.check_out, Time_OfAction = new DateTime(2025, 3, 5, 16, 55, 0) }
            );
        }
    }
}
