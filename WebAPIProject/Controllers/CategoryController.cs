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
        public IActionResult AddCategory(Category c)
        {
            context.categories.Add(c);
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("DeleteCategory")]
        public IActionResult DeleteCategory(int id)
        {
            Category c = context.categories.FirstOrDefault(c => c.CategoryId == id);
            if (c == null)
            {
                return NotFound("Category not Found.");
            }
            else
            {
                context.categories.Remove(c);
                return Ok("Category Deleted Successfully.");
            }

        }

        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            Category c = context.categories.FirstOrDefault(c => c.CategoryId == id);
            return Ok(c);

        }

        [HttpGet("GetCategories")]
        public IActionResult GetCategories()
        {
            List<Category> categories = context.categories.ToList();
            return Ok(categories);
        }

    }
}
