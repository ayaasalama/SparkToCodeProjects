using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    [ApiController]
    [Route("Category")]
    public class CategoryController : ControllerBase
    {
        private ProjectContext context;
        public CategoryController(ProjectContext _context)
        {
            context = _context;
        }

        [HttpPost("AddCategory")]
        public void AddCategory(Category c)
        {
            context.categories.Add(c);
            context.SaveChanges();
        }

        [HttpDelete("DeleteCategory")]
        public void DeleteCategory(int id)
        {
            Category c = context.categories.FirstOrDefault(c => c.CategoryId == id);
            if (c == null)
            {
            }
            else
            {
                context.categories.Remove(c);
            }

        }

        [HttpGet("GetCategory")]
        public Category GetCategory(int id)
        {
            Category c = context.categories.FirstOrDefault(c => c.CategoryId == id);
            return c;

        }

        [HttpGet("GetCategories")]
        public List<Category> GetCategories()
        {
            List<Category> categories = context.categories.ToList();
            return categories;
        }

    }
}
