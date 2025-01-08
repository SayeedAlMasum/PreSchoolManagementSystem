using System.Collections.Generic;
using System.Data;
using Database.Model;
using Microsoft.EntityFrameworkCore;

namespace Database.Context
{
    public class PreSchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-1H8PV8J\EXPRESS01;Database=SkillExchangeManagementSystem;Trusted_Connection=True;TrustServerCertificate=True;ConnectRetryCount=0");
        }
        public DbSet<UserInfo>? UserInfo { get; set; }
        public DbSet<Student>? Student { get; set; }
        public DbSet<Teacher>? Skills { get; set; }
        public DbSet<ParentGuardian>? ParentGuardian { get; set; }
        public DbSet<Event>? Event { get; set; }
        public DbSet<Class>? Class { get; set; }
        public DbSet<Fee>? Fee { get; set; }
        public DbSet<Attendance>? Attendance { get; set; }
        public DbSet<Assessment>? Assessment { get; set; }
        public DbSet<Role>? Role { get; set; }

    }

}