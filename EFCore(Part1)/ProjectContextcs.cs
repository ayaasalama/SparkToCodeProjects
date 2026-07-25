using EFCore_Part1_.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Part1_
{
    public class ProjectContextcs : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet <Project> projects { get; set; }
        public DbSet<Dependent> dependents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server = .; Database= CompanyDB; Trusted_Connection=True; " +
                "TrustServerCertificate=True;"
            );
        }
    }
}
