using ECommerceTask.models;

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
        static void RegisterUser()
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
        static void Login()
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
        static void AddCategory()
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
        static void AddProduct()
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
    }
}
