using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace TaskMVC.Models
{
    public class CompanyContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        public CompanyContext(DbContextOptions  options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<Task>()
                .HasOne(t => t.Employee)
                .WithMany(e => e.Tasks)
                .HasForeignKey(t => t.EmployeeId);

            modelBuilder.Entity<Manager>()
                .HasMany(m => m.Departments)
                .WithOne()
                .OnDelete(DeleteBehavior.SetNull);
        }
    }


}