using ECommerceTask.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceTask
{
    public class TaskContext: DbContext
    {
        public DbSet<Category> category {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server = DESKTOP-NB7NDOC\\SQLEXPRESS; Database= ECommerceDB; Trusted_Connection=True; " +
                "TrustServerCertificate=True;"
            );
        }
    }
}
