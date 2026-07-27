using EFCore_Bank1_.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Bank1_
{
    public class BankDbContext : DbContext
    {
        public DbSet<BankAccount> BankAccounts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            "Server=DESKTOP-NB7NDOC\\SQLEXPRESS;Database=BankDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
