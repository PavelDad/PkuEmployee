using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PkuEmployee.Model
{
    public class PkuEmployeeContext : DbContext
    {
        public DbSet<EmployeesSubject> EmployeesSubjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Order> Orders { get; set; }

        public PkuEmployeeContext()
        {
            try
            {
                if (!Directory.Exists($@"{Application.StartupPath}\Database"))
                {
                    Directory.CreateDirectory($@"{Application.StartupPath}\Database");
                }
                Database.EnsureCreated();
            }
            catch (Exception)
            {
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = $@"{Application.StartupPath}\Database\pkuEmploees.db";
            optionsBuilder
                .UseSqlite($@"Data Source = {dbPath}")
                //.UseSqlite(@"Data Source = .\Database\pkuEmploees.db")
                //.UseSqlite(@"Data Source = E:\Databases\pkuEmploees.db")
                .UseLazyLoadingProxies();
        }
    }
}
