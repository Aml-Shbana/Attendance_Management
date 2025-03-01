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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; database = Attendance_Management; Trusted_Connection = True; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>().HasOne(e => e.Employee).WithMany(e => e.Attendances).HasForeignKey(e => e.EmployeeID);
            modelBuilder.Entity<LeaveRequest>().HasOne(e=>e.Employee).WithMany(e=> e.Leaves).HasForeignKey(e=>e.EmployeeID);
         }
    }
}
