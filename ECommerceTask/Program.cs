using ECommerceTask.models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceTask
{
    internal class Program
    {
        static TaskContext context = new TaskContext();

        static int loggedInUserId = 0;

        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== E-Commerce Console App =====");
                Console.WriteLine(" 1. Register New User");
                Console.WriteLine(" 2. Login");
                Console.WriteLine(" 3. Add New Category");
                Console.WriteLine(" 4. Add New Product");
                Console.WriteLine(" 5. View All Products");
                Console.WriteLine(" 6. Place an Order");
                Console.WriteLine(" 7. View My Orders");
                Console.WriteLine(" 8. View Order Details");
                Console.WriteLine(" 9. Add a Review for an Order");
                Console.WriteLine("10. View All Reviews for a Product");
                Console.WriteLine("11. Logout");
                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1: RegisterUser(); break;
                    case 2: Login(); break;
                    case 3: AddCategory(); break;
                    case 4: AddProduct(); break;
                    case 5: ViewAllProducts(); break;
                    case 6: PlaceOrder(); break;
                    case 7: ViewMyOrders(); break;
                    case 8: ViewOrderDetails(); break;
                    case 9: AddReview(); break;
                    case 10: ViewReviewsForProduct(); break;
                    case 11: Logout(); break;
                    case 0:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

            }
        }

        // Case 1
        public static void RegisterUser()
        {
            Console.WriteLine("Register User:");
            User user = new User();

            Console.Write("Enter your Name: ");
            user.UserName = Console.ReadLine();

            Console.Write("Enter your Email: ");
            user.UserEmail = Console.ReadLine();

            Console.Write("Enter your Password: ");
            user.UserPassword = Console.ReadLine();

            if (user.UserName == null || user.UserName.Trim() == "" ||
                   user.UserEmail == null || user.UserEmail.Trim() == "" ||
                   user.UserPassword == null || user.UserPassword.Trim() == "")
            {
                Console.WriteLine("Registration failed. All fields are required.");
                return;
            }

            // Check if email already exists
            bool emailExists = context.user
                .Any(u => u.UserEmail == user.UserEmail);

            if (emailExists)
            {
                Console.WriteLine("Registration failed. This email is already registered.");
                return;
            }

            context.user.Add(user);
            context.SaveChanges();

            Console.WriteLine("User registered successfully.");

        }

        // Case 2
        public static void Login()
        {
            Console.WriteLine("\nLogin: ");

            Console.Write("Enter your Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your Password: ");
            string password = Console.ReadLine();

            User foundUser = context.user.FirstOrDefault(u => u.UserEmail == email && u.UserPassword == password);

            if (foundUser != null)
            {
                loggedInUserId = foundUser.UserId;

                Console.WriteLine("Login successful.");
                Console.WriteLine("Welcome, " + foundUser.UserName + "!");
            }
            else
            {
                Console.WriteLine("Invalid email or password.");
            }
        }

        // Case 3
        public static void AddCategory()
        {
            Console.WriteLine("\nAdd New Category: ");

            Category category = new Category();

            Console.Write("Enter Category Name: ");
            category.CategoryName = Console.ReadLine();

            Console.Write("Enter Category Type: ");
            category.CategoryType = Console.ReadLine();

            // Check whether any field is null or empty
            if (category.CategoryName == null ||
                category.CategoryName.Trim() == "" ||
                category.CategoryType == null ||
                category.CategoryType.Trim() == "")
            {
                Console.WriteLine("Category was not added. All fields are required.");
                return;
            }

            context.category.Add(category);
            context.SaveChanges();

            Console.WriteLine("Category added successfully.");
        }


        // Case 4
        public static void AddProduct()
        {
            Console.WriteLine("\nAdd New Product: ");

            // Get existing categories
            List<Category> categories = context.category.ToList();

            // No categories then cant add the product
            if (categories.Count == 0)
            {
                Console.WriteLine("No categories exist. Add a category first.");
                return;
            }

            Product product = new Product();

            Console.Write("Enter Product Name: ");
            product.ProductName = Console.ReadLine();

            if (product.ProductName == null ||
                product.ProductName.Trim() == "")
            {
                Console.WriteLine("Product name is required.");
                return;
            }

            Console.Write("Enter Product Price: ");
            try
            {
                product.ProductPrice = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid price. Please enter a number.");
                return;
            }

            if (product.ProductPrice <= 0)
            {
                Console.WriteLine("Product price must be greater than zero.");
                return;
            }

            // Display existing categories
            Console.WriteLine("\nAvailable Categories:");

            foreach (Category category in categories)
            {
                Console.WriteLine(
                    category.CategoryId + ". " +
                    category.CategoryName + " - " +
                    category.CategoryType
                );
            }

            Console.Write("Enter the Category ID: ");
            int categoryId;

            try
            {
                categoryId = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Category ID. Please enter a number.");
                return;
            }

            // Check whether the selected category exists
            Category? selectedCategory = context.category
                .FirstOrDefault(c => c.CategoryId == categoryId);

            if (selectedCategory == null)
            {
                Console.WriteLine("Category not found.");
                return;
            }

            // Link the product to the selected category
            product.CategoryId = selectedCategory.CategoryId;

            context.product.Add(product);
            context.SaveChanges();

            Console.WriteLine("Product added successfully.");
        }

        // Case 5
        public static void ViewAllProducts()
        {
            Console.WriteLine("\nView Products: ");

            if (context.product.Count() == 0)
            {
                Console.WriteLine("No products are available.");
                return;
            }

            Console.WriteLine("Available Categories:");

            List<Category> categories = context.category.ToList();

            foreach (Category category in categories)
            {
                Console.WriteLine(
                    category.CategoryId + ". " +
                    category.CategoryName
                );
            }

            Console.WriteLine("0. View All Products");
            Console.Write("Enter a Category ID, or enter 0 to view all: ");

            int categoryId;

            try
            {
                categoryId = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            List<Product> products;

            if (categoryId == 0)
            {
                // show all products and their categories
                products = context.product.Include(p => p.Category)
                                          .ToList();
            }
            else
            {
                Category selectedCategory = context.category.FirstOrDefault(c => c.CategoryId == categoryId);

                if (selectedCategory == null)
                {
                    Console.WriteLine("Category not found.");
                    return;
                }

                // Show products in the selected category
                products = context.product.Include(p => p.Category)
                                          .Where(p => p.CategoryId == categoryId)
                                          .ToList();
            }

            if (products.Count == 0)
            {
                Console.WriteLine("No products were found in this category.");
                return;
            }

            Console.WriteLine("\nProduct List =====");

            foreach (Product product in products)
            {
                Console.WriteLine(
                    "Name: " + product.ProductName +
                    " | Price: " + product.ProductPrice.ToString("0.00") +
                    " | Category: " + product.Category.CategoryName
                );
            }
        }

        // Helper Function
        public static bool IsUserLoggedIn()
        {
            if (loggedInUserId == 0)
            {
                Console.WriteLine("You must log in first.");
                return false;
            }

            return true;
        }

        // Case 6
        public static void PlaceOrder()
        {
            Console.WriteLine("Place an Order: ");

            if (!IsUserLoggedIn())
            {
                return;
            }

            List<Product> products = context.product.ToList();

            if (products.Count == 0)
            {
                Console.WriteLine("No products are available.");
                return;
            }

            // Display the available products
            Console.WriteLine("\nAvailable Products:");

            foreach (Product product in products)
            {
                Console.WriteLine(
                    product.ProductId + ". " +
                    product.ProductName +
                    " - Price: " +
                    product.ProductPrice.ToString("0.00")
                );
            }

            List<OrderProduct> selectedProducts = new List<OrderProduct>();

            while (true)
            {
                Console.Write("\nEnter Product ID, or enter 0 to finish: ");
                int productId;

                try
                {
                    productId = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                
                if (productId == 0)
                {
                    break;
                }

                // Check if selected product exists
                Product selectedProduct = products.FirstOrDefault(p => p.ProductId == productId);

                if (selectedProduct == null)
                {
                    Console.WriteLine("Product not found.");
                    continue;
                }

                // Prevent same product from being selected twice
                bool alreadySelected = selectedProducts.Any(ap => ap.ProductId == productId);

                if (alreadySelected)
                {
                    Console.WriteLine("This product has already been selected.");
                    continue;
                }

                Console.Write("Enter Quantity: ");
                int quantity;

                try
                {
                    quantity = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid quantity. Please enter a number.");
                    continue;
                }

                if (quantity <= 0)
                {
                    Console.WriteLine("Quantity must be greater than zero.");
                    continue;
                }

                OrderProduct orderProduct = new OrderProduct();

                orderProduct.ProductId = productId;
                orderProduct.Quantity = quantity;

                selectedProducts.Add(orderProduct);

                Console.WriteLine(
                    selectedProduct.ProductName +
                    " was added to the order."
                );
            }

            if (selectedProducts.Count == 0)
            {
                Console.WriteLine("No products were selected. Order was not created.");
                return;
            }

            Order order = new Order();

            order.OrderDate = DateTime.Now;
            order.CustomerId = loggedInUserId;

            context.order.Add(order);
            context.SaveChanges();

            foreach (OrderProduct orderProduct in selectedProducts)
            {
                orderProduct.OrderId = order.OrderId;

                context.orderProducts.Add(orderProduct);
            }

            context.SaveChanges();

            Console.WriteLine("\nOrder placed successfully.");
            Console.WriteLine("Order ID: " + order.OrderId);
        }

        // Case 7
        public static void ViewMyOrders()
        {
            Console.WriteLine("\nMy Orders: ");

            if (!IsUserLoggedIn())
            {
                return;
            }

            List<Order> myOrders = context.order.Where(o => o.CustomerId == loggedInUserId)
                                                .ToList();

            if (myOrders.Count == 0)
            {
                Console.WriteLine("You have not placed any orders.");
                return;
            }

            foreach (Order order in myOrders)
            {
                Console.WriteLine(
                    "Order ID: " + order.OrderId +
                    " | Order Date: " + order.OrderDate
                );
            }
        }

    }
}
