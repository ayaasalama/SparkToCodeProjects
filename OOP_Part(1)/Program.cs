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
        static Product Product2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    case 1: ViewAccountDetails(); break;
                    case 2: UpdateStudentAddress(); break;
                    case 3: MakeDeposit(); break;
                    case 4: MakeWithdrawal(); break;
                    case 5: ViewProductDetails(); break;
                    case 6: RegisterStudent(); break;
                    case 7: CompareAccountBalances(); break;
                    case 8: RestockProduct(); break;
                    case 9: TransferBetweenAccounts(); break;
                    case 10: UpdateStudentGrade(); break;
                    case 11: StudentReportCard(); break;
                    case 12: AccountHealthStatus(); break;
                    case 13: BulkSaleWithRevenue(); break;
                    case 14: ScholarshipEligibilityCheck(); break;
                    case 15: FullBalanceTopUpFlow(); break;
                    case 16: QuickAccountOpening(); break;
                    case 17: TotalStudentsCounter(); break;
                    case 18: OverdrawnAccountCheck(); break;
                    case 19: SetStudentSecurityPin(); break;
                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }
            }

        }

        // Case 1 - View Account Details
        public static void ViewAccountDetails()
        {
            Console.WriteLine("Choose an account (1 or 2)");
            
            int account;
            try
            {
                account = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
                return;
            }

            switch (account)
            {
                case 1: BankAccount1.CheckBalance(); break;
                case 2: BankAccount2.CheckBalance(); break;
                default : Console.WriteLine("Invalid number"); break;
            }

        }

        // Case 2 - Update Student Address
        public static void  UpdateStudentAddress()
        {
            Console.WriteLine("Choose a Student (1 or 2)");

            int choice;
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
                return;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the new address for Student1:");
                    Student1.Address = Console.ReadLine();
                    Console.WriteLine("Confirmation: Student 1 address updated to: " + Student1.Address);
                break;

                case 2:
                    Console.WriteLine("Enter the new address for Student2: ");
                    Student2.Address = Console.ReadLine();
                    Console.WriteLine("Confirmation: Student 2 address updated to: " + Student2.Address);
                    break;

                default: Console.WriteLine("Invalid number"); break;
            }
        }


    }

}
