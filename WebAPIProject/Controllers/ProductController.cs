using Microsoft.AspNetCore.Mvc;
using WebAPIProject.Models;
namespace WebAPIProject.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        private ProjectContext context;
        public ProductController(ProjectContext _context)
        {
            context = _context;
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct(Product p)
        {
            context.products.Add(p);
            context.SaveChanges();

            return Ok();

        }

        [HttpPost("DeleteProduct")]
        public IActionResult DeleteProduct(int id)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);
            if (p == null)
            {
                return NotFound("Product not found.");
            }
            else 
            {
                context.products.Remove(p);
                return Ok("Product deleted successfully.");
            }
           
        }

        [HttpGet("GetProduct")]
        public IActionResult GetProduct (int id)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);
            return Ok(p);

        }

        [HttpGet("GetProducts")]
        public IActionResult GetProducts ()
        {
            List<Product> products = context.products.ToList();
            return Ok(products);
        }

        [HttpPatch("UpdateProductPrice")]
        public IActionResult UpdateProductPrice(int id, double newPrice)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);

            p.Price = newPrice;

            context.SaveChanges();
            return Ok();
        }

        [HttpPatch("UpdateProductName")]
        public IActionResult UpdateProductName(int id, string newName)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);

            p.ProductName = newName;

            context.SaveChanges();
            return Ok();

        }

        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct(int id, Product newProduct)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);

            p.Price = newProduct.Price;
            p.ProductName = newProduct.ProductName;
            p.ProductDescription = newProduct.ProductDescription;

            context.SaveChanges();
            return Ok();

        }

    }
}
