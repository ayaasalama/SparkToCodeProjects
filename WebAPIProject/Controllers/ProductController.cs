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
    }
}
