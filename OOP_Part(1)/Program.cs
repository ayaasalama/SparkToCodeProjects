namespace OOP_Part_1_
{
    // First Class BankAccount
    public class BankAccount
    {
        // Properties
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        // Methods
        public void Deposit(double amount)
        {
            Balance += amount;

            SendEmail();
        }
        public void Withdraw(double amount)
        {
            if (Balance > amount)
            {
                Balance -= amount;

                SendEmail();
            }
            else
            {
                Console.WriteLine("Balance Insufficient!");
            }
        }
        public double CheckBalance()
        {
            PrintInformation();
            
            return Balance;
        }
        private void PrintInformation()
        {
            Console.WriteLine("HolderName: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }
        private void SendEmail()
        {
            Console.WriteLine("Sending an Email...");
        }
    }

    // Second Class Student
    public class Student
    {
        // Properties
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string email {  get; set; }
        int age { get; set; }

        // Methods
        public void Register(string Email)
        {
            email = Email;

            SendEmail();
        }
        private void SendEmail()
        {
            Console.WriteLine("Registeration Email is being Sent...");
        }


    }

    // Third Class Product
    public class Product
    {
       // Properties
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        // Methods
        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Stock not enough!");
            }
            
            LogTransaction();
        }
        public void Restock(int quantity)
        {
            StockQuantity += quantity;

            LogTransaction();
        }
        public double GetInventoryValue()
        {
            PrintDetails();

            return Price * StockQuantity;
        }
        private void PrintDetails()
        {
            Console.WriteLine("ProductName: " + ProductName);
            Console.WriteLine("Price: " + Price + " OMR");
            Console.WriteLine("Stock Quantity: " + StockQuantity);
        }
        private void LogTransaction()
        {
            Console.WriteLine("The transaction is logged.. ");
        }

    }

    internal class Program
    {
        // Declaring and Assigning Objects
        static BankAccount BankAccount1 = new BankAccount { AccountNumber = 1163, HolderName = "Karim", Balance = 120 };
        static BankAccount BankAccount2 = new BankAccount { AccountNumber = 15203, HolderName = "Ali", Balance = 63 };

        static Student Student1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
        static Student Student2 = new Student { Name = "Ahmed", Address = "Muscat", Grade = 70 };

        static Product Product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
        static Product Product2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.700, StockQuantity = 20 };

        static void Main(string[] args)
        {
            

        }
    }
}
