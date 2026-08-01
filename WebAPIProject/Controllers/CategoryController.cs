using Microsoft.EntityFrameworkCore;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    public class CategoryController
    {
        private ProjectContext context;
        public CategoryController(ProjectContext _context)
        {
            context = _context;
        }

        public void AddCategory(Category c)
        {
            context.categories.Add(c);
            context.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            Category c = context.categories.FirstOrDefault(c => c.CategoryId == id);
            if (c == null)
            {
            }
            else
            {
                context.products.Remove(p);
            }

        }

        public Category GetCategory(int id)
        {
            Category c = context.categories.FirstOrDefault(c => c.CategoryId == id);
            return c;

        }

        public List<Category> GetCategories()
        {
            List<Category> categories = context.categories.ToList();
            return categories;
        }

    }
}
