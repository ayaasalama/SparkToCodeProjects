using Microsoft.EntityFrameworkCore;
using WebAPIProject.Models;

namespace WebAPIProject
{
    public class ProjectContext: DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }


    }
}
