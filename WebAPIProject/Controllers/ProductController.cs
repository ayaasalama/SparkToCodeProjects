using Microsoft.AspNetCore.Mvc;
using WebAPIProject.Models;
namespace WebAPIProject.Controllers
{
    public class ProductController
    {
        private ProjectContext context;
        public ProductController(ProjectContext _context)
        {
            context = _context;
        }

        [HttpPost("AddProduct")]
        public void AddProduct(Product p)
        {
            context.products.Add(p);
            context.SaveChanges();

        }

        [HttpPost("DeleteProduct")]
        public void DeleteProduct(int id)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);
            if (p == null)
            {
            }
            else 
            {
                context.products.Remove(p);
            }
           
        }

        [HttpGet("GetProduct")]
        public Product GetProduct (int id)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);
            return p;

        }

        [HttpGet("GetProducts")]
        public List<Product> GetProducts ()
        {
            List<Product> products = context.products.ToList();
            return products;
        }

        [HttpPatch("UpdateProductPrice")]
        public void UpdateProductPrice(int id, double newPrice)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);

            p.Price = newPrice;

            context.SaveChanges();
        }

        [HttpPatch("UpdateProductName")]
        public void UpdateProductName(int id, string newName)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);

            p.ProductName = newName;

            context.SaveChanges();

        }

        [HttpPut("UpdateProduct")]
        public void UpdateProduct(int id, Product newProduct)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);

            p.Price = newProduct.Price;
            p.ProductName = newProduct.ProductName;
            p.ProductDescription = newProduct.ProductDescription;

            context.SaveChanges();

        }

    }
}
