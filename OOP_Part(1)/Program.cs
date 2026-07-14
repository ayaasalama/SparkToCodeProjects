using System.Collections;
using System.Security.Principal;

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

            double inventoryValue = Price * StockQuantity;
            Console.WriteLine("Total Inventory Value: " + inventoryValue.ToString("F2") + " OMR");
            return inventoryValue;
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

        // Case 3 - Make a Deposit
        public static void MakeDeposit()
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

            Console.WriteLine("Enter the amount to deposit:");
            double amount = double.Parse(Console.ReadLine());

            switch (account)
            {
                case 1: 
                    BankAccount1.Deposit(amount);

                    Console.WriteLine("Account Holder: " + BankAccount1.HolderName);
                    Console.WriteLine("Updated Balance: " + BankAccount1.Balance.ToString("F2") + " OMR");
                break;

                case 2:
                    BankAccount2.Deposit(amount);

                    Console.WriteLine("Account Holder: " + BankAccount2.HolderName);
                    Console.WriteLine("Updated Balance: " + BankAccount2.Balance.ToString("F2") + " OMR");
                break;

                default: Console.WriteLine("Invalid number"); break;
            }
        }

        // Case 4 - Make a Withdrawal
        public static void MakeWithdrawal()
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

            Console.WriteLine("Enter the amount to Withdraw:");
            double amount = double.Parse(Console.ReadLine());

            switch (account)
            {
                case 1:
                    BankAccount1.Withdraw(amount);

                    Console.WriteLine("Account Holder: " + BankAccount1.HolderName);
                    Console.WriteLine("Updated Balance: " + BankAccount1.Balance.ToString("F2") + " OMR");
                    break;

                case 2:
                    BankAccount2.Withdraw(amount);

                    Console.WriteLine("Account Holder: " + BankAccount2.HolderName);
                    Console.WriteLine("Updated Balance: " + BankAccount2.Balance.ToString("F2") + " OMR");
                    break;

                default: Console.WriteLine("Invalid number"); break;
            }
        }

        // Case 5 - View Product Details
        public static void ViewProductDetails()
        {
            Console.WriteLine("Choose a Product (1 or 2)");

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
                case 1: Product1.GetInventoryValue(); break;
                case 2: Product2.GetInventoryValue(); break;
                default: Console.WriteLine("Invalid number"); break;
            }
        }

        // Case 6 - Register a Student
        public static void RegisterStudent()
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

            Console.Write("Enter student email address: ");
            string inputEmail = Console.ReadLine();

            switch (choice)
            {
                case 1:
                    Student1.Register(inputEmail);
                    Console.WriteLine("Success: Registration confirmed for " + Student1.Name);
                break;

                case 2:
                    Student2.Register(inputEmail);
                    Console.WriteLine("Success: Registration confirmed for " + Student2.Name);
                break;

                default: Console.WriteLine("Invalid number"); break;
            }
        }

        // Case 7 -  Compare Two Account Balances
        public static void CompareAccountBalances()
        {
            double Balance1 = BankAccount1.Balance;
            double Balance2 = BankAccount2.Balance;

            if (Balance1 > Balance2)
            {
                Console.WriteLine("Balance in BankAccount1 Holds more Money.");
            }
            else if (Balance1 < Balance2)
            {
                Console.WriteLine("Balance in BankAccount2 Holds more Money.");
            }
            else
            {
                Console.WriteLine("Both Account Balances are equal.");
            }

        }

        // Case 8 - Restock Product & Stock Level Check
        public static void RestockProduct()
        {
            Console.WriteLine("Choose a Product (1 or 2)");

            int product;
            try
            {
                product = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
                return;
            }

            Console.WriteLine("Enter the Restock Quantity:");
            int quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case 1: 
                    Product1.Restock(quantity); 

                    if (Product1.StockQuantity < 10)
                    {
                        Console.WriteLine("Product1 Stock is Low.");
                    }
                    else if (Product1.StockQuantity >= 10 && Product1.StockQuantity < 50)
                    {
                        Console.WriteLine("Product1 Stock is Moderate.");
                    }
                    else
                    {
                        Console.WriteLine("Product1 is Well Stocked.");
                    }

                break;

                case 2: 
                    Product2.Restock(quantity);

                    if (Product2.StockQuantity < 10)
                    {
                        Console.WriteLine("Product2 Stock is Low.");
                    }
                    else if (Product2.StockQuantity >= 10 && Product2.StockQuantity < 50)
                    {
                        Console.WriteLine("Product2 Stock is Moderate.");
                    }
                    else
                    {
                        Console.WriteLine("Product2 is Well Stocked.");
                    }

                    break;

                default: Console.WriteLine("Invalid number"); break;
            }

        }

        // Case 9 - Transfer between Accounts
        public static void TransferBetweenAccounts()
        {
            BankAccount sourceAccount;
            BankAccount destinationAccount;

            Console.WriteLine("Choose Source Account (1 or 2):");
            int senderchoice = int.Parse(Console.ReadLine());

            switch(senderchoice)
            {
                case 1:
                    sourceAccount = BankAccount1;
                    break;

                case 2:
                    sourceAccount = BankAccount2;
                    break;

                default: Console.WriteLine("Invalid Selection."); return;

            }

            Console.WriteLine("Choose Destination Account (1 or 2):");
            int destinationchoice = int.Parse(Console.ReadLine());

            switch (destinationchoice)
            {
                case 1:
                    destinationAccount = BankAccount1;
                    break;

                case 2:
                    destinationAccount = BankAccount2;
                    break;

                default: Console.WriteLine("Invalid Selection."); return;

            }

            Console.WriteLine("Enter the Transfer Amount:");
            double transferAmount = double.Parse(Console.ReadLine());

            if (sourceAccount.Balance >= transferAmount)
            {
                sourceAccount.Withdraw(transferAmount);
                destinationAccount.Deposit(transferAmount);

                Console.WriteLine("\n--- Transfer Successful ---");
                Console.WriteLine("Source Account New Balance: " + sourceAccount.Balance.ToString("F2") +  " OMR");
                Console.WriteLine("Destination Account New Balance: " + destinationAccount.Balance.ToString("F2") + " OMR");
            }
            else
            {
                Console.WriteLine("Transfer Failed: Source account has insufficient funds!");
            }

        }

        // Case 10 - Update Student Greade (validated)
        public static void UpdateStudentGrade()
        {
            Console.WriteLine("Choose a Student (1 or 2 ):");
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

            Console.WriteLine("Enter the new Grade (0-100):");
            int newGrade;

            try
            {
                newGrade = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Grade must be a valid whole number.");
                return; 
            }

            if (newGrade < 0 || newGrade > 100)
            {
                Console.WriteLine("Rejecting update: Grade falls outside the 0-100 range.");
                return; 
            }

            switch (choice)
            {
                case 1:
                    Student1.Grade = newGrade;
                    Console.WriteLine("Confirmation: Student 1 grade updated to: " + Student1.Grade);
                    break;

                case 2:
                    Student2.Grade = newGrade;
                    Console.WriteLine("Confirmation: Student 2 grade updated to: " + Student2.Grade);
                    break;
            }

        }

        // Case 11 - Student Report Card
        public static void StudentReportCard()
        {
            Console.WriteLine("Choose a Student (1 or 2 ):");
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

            Student selectedStudent;

            switch (choice)
            {
                case 1: selectedStudent = Student1; break;
                case 2: selectedStudent = Student2; break;
                default:
                    Console.WriteLine("Invalid selection.");
                    return;
            }

            Console.WriteLine("----- Student Report Card -----");
            Console.WriteLine("Name: " + selectedStudent.Name);
            Console.WriteLine("Address: " + selectedStudent.Address);
            Console.WriteLine("Grade  : " + selectedStudent.Grade);

            if (selectedStudent.Grade >= 60)
            {
                Console.WriteLine("Status : Pass");
            }
            else
            {
                Console.WriteLine("Status : Fail");
            }

        }

        // Case 12 - Account Health Status
        public static void AccountHealthStatus()
        {
            Console.WriteLine("Choose a Account (1 or 2 ):");
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

            BankAccount selectedAccount;

            switch (account)
            {
                case 1: selectedAccount = BankAccount1; break;
                case 2: selectedAccount = BankAccount2; break;
                default:
                    Console.WriteLine("Invalid selection.");
                    return;
            }

            if (selectedAccount.Balance < 50)
            {
                Console.WriteLine("Status : Low Balance");
            }
            else if (selectedAccount.Balance >= 50 && selectedAccount.Balance <= 1000)
            {
                Console.WriteLine("Status : Healthy");
            }
            else
            {
                Console.WriteLine("Premium");
            }
        }

        // Case 13 - Bulk Sale With Revenue Calculation
        public static void BulkSaleWithRevenue()
        {
            Console.WriteLine("Choose a Product (1 or 2)");

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

            Console.WriteLine("Enter a quantity to sell:");
            int quantity;

            try
            {
                quantity = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Product selectedProduct;

            switch (choice)
            {
                case 1: selectedProduct = Product1; break;
                case 2: selectedProduct = Product2; break;
                default:
                    Console.WriteLine("Invalid selection.");
                    return;
            }

            if (selectedProduct.StockQuantity < quantity)
            {
                quantity -= selectedProduct.StockQuantity;
                Console.WriteLine("The additional units needed is: " + quantity);
                return;
            }
            else
            {
                selectedProduct.Sell(quantity);
                double revenue = selectedProduct.Price * quantity;
                Console.WriteLine("The total revenue is: " + revenue + " OMR");
            }
        }

    }

}
