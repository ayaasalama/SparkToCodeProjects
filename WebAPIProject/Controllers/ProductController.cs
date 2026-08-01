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


        public void AddProduct(Product p)
        {
            context.products.Add(p);
            context.SaveChanges();

        }

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
        public Product GetProduct (int id)
        {
            Product p = context.products.FirstOrDefault(p => p.ProductId == id);
            return p;

        }


    }
}
