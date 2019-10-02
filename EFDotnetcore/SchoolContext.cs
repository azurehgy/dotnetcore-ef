using EFDotnetcore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDotnetcore
{
    public class SchoolContext : DbContext
    {
        private const string dbconnstr = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(dbconnstr);
        }
    }
}
