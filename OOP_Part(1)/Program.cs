using System.Collections;
using System.Runtime.Intrinsics.X86;
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

        // Case 18 - Overdrawn Account Check[Read - Only Property]
        public bool IsOverdrawn
        {
            get
            {
                return Balance < 0;
            }
        }

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
            Console.WriteLine("Balance: " + Balance + " OMR");
        }
        private void SendEmail()
        {
            Console.WriteLine("Sending an Email...");
        }

        // To stop showing errors after Case 16
        public BankAccount()
        {
        }

        // case 16 - Quick Account Opening [Parameterized Constructor]
        public BankAccount(int accountNumber, string holderName, double startingBalance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = startingBalance;
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

        // Case 19 - Set Student Security PIN [Write-Only Property]
        private int securityPin;

        public int SecurityPIN
        {
            set
            {
                securityPin = value;
            }
        }

        // Case 17 - Total Students Counter [Static Fields & Methods]
        private static int studentCount = 0;

        public Student()
        {
            studentCount++; 
        }

        public static int GetTotalStudents()
        {
            return studentCount;
        }

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

                Console.WriteLine("Press any Key.");
                Console.ReadKey();
                Console.Clear();
            }

        }

        // Helper Functions
        // BankAccount Choose
        public static BankAccount SelectedAccount()
        {
            Console.Write("Choose an account (1 or 2):");
            int choice;
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
                return null;
            }

            switch (choice)
            {
                case 1: return BankAccount1;
                case 2: return BankAccount2;
                default:
                    Console.WriteLine("Invalid selection.");
                    return null;
            }
        }

        // Student Choose
        public static Student SelectedStudent()
        {
            Console.Write("Choose a Student (1 or 2):");
            int choice;
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
                return null;
            }

            switch (choice)
            {
                case 1: return Student1;
                case 2: return Student2;
                default:
                    Console.WriteLine("Invalid selection.");
                    return null;
            }
        }
        


        // Case 1 - View Account Details
        public static void ViewAccountDetails()
        {
            BankAccount selectedAccount = SelectedAccount();

            if (selectedAccount == null) return;

            selectedAccount.CheckBalance();

        }

        // Case 2 - Update Student Address
        public static void  UpdateStudentAddress()
        {
            Student selectedStudent = SelectedStudent();
            if (selectedStudent == null) return;

            Console.Write("Enter the new address:");
            string Address = Console.ReadLine();
            Console.WriteLine("Confirmation: Address updated to: " + selectedStudent.Address);

        }

        // Case 3 - Make a Deposit
        public static void MakeDeposit()
        {
            BankAccount selectedAccount = SelectedAccount();

            if (selectedAccount == null) return;

            Console.Write("Enter the amount to deposit:");
            double amount = double.Parse(Console.ReadLine());

            selectedAccount.Deposit(amount);
            Console.WriteLine("Account Holder: " + selectedAccount.HolderName);
            Console.WriteLine("Updated Balance: " + selectedAccount.Balance.ToString("F2") + " OMR");

        }

        // Case 4 - Make a Withdrawal
        public static void MakeWithdrawal()
        {
            BankAccount selectedAccount = SelectedAccount();

            if (selectedAccount == null) return;

            Console.Write("Enter the amount to Withdraw:");
            double amount = double.Parse(Console.ReadLine());

            selectedAccount.Withdraw(amount);
            Console.WriteLine("Account Holder: " + selectedAccount.HolderName);
            Console.WriteLine("Updated Balance: " + selectedAccount.Balance.ToString("F2") + " OMR");

        }

        // Case 5 - View Product Details
        public static void ViewProductDetails()
        {
            Console.Write("Choose a Product (1 or 2)");

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
            Student selectedStudent = SelectedStudent();
            if (selectedStudent == null) return;

            Console.Write("Enter student email address: ");
            string inputEmail = Console.ReadLine();

            selectedStudent.Register(inputEmail);
            Console.WriteLine("Success: Registration confirmed for " + selectedStudent.Name);

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
            Console.Write("Choose a Product (1 or 2)");

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

            Console.Write("Enter the Restock Quantity:");
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
            Console.WriteLine("Source Account Selection");
            BankAccount sourceAccount = SelectedAccount();
            if (sourceAccount == null) return;

            Console.WriteLine("Destination Account Selection");
            BankAccount destinationAccount = SelectedAccount();
            if (destinationAccount == null) return;

            if (sourceAccount.AccountNumber == destinationAccount.AccountNumber)
            {
                Console.WriteLine("Transfer Failed: Source and Destination accounts cannot be the same.");
                return;
            }

            Console.Write("\nEnter the Transfer Amount: ");
            double transferAmount;
            try
            {
                transferAmount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount input.");
                return;
            }

            if (sourceAccount.Balance >= transferAmount)
            {
                sourceAccount.Withdraw(transferAmount);
                destinationAccount.Deposit(transferAmount);

                Console.WriteLine("Transfer Successful:");
                Console.WriteLine("Source Account New Balance: " + sourceAccount.Balance.ToString("F2") + " OMR");
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
            Student selectedStudent = SelectedStudent();
            if (selectedStudent == null) return;

            Console.Write("Enter the new Grade (0-100):");
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

            selectedStudent.Grade = newGrade;
            Console.WriteLine("Confirmation: Grade updated to: " + selectedStudent.Grade);

        }

        // Case 11 - Student Report Card
        public static void StudentReportCard()
        {
            Student selectedStudent = SelectedStudent();
            if (selectedStudent == null) return;

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
            BankAccount selectedAccount = SelectedAccount();

            if (selectedAccount == null) return;

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
                Console.WriteLine("Status : Premium");
            }
        }

        // Case 13 - Bulk Sale With Revenue Calculation
        public static void BulkSaleWithRevenue()
        {
            Console.Write("Choose a Product (1 or 2)");

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

            Console.Write("Enter a quantity to sell:");
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

        // Case 14 - Scholarship Eligibility Check
        public static void ScholarshipEligibilityCheck()
        {
            Student selectedStudent = SelectedStudent();
            if (selectedStudent == null) return;

            BankAccount selectedAccount = SelectedAccount();
            if (selectedAccount == null) return;

            if (selectedStudent.Grade >= 80 && selectedAccount.Balance >= 100)
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                if (selectedStudent.Grade < 80)
                {
                    Console.WriteLine("Failed: Student's Grade is below 80.");
                }

                if (selectedAccount.Balance < 100)
                {
                    Console.WriteLine("Failed: Account Balance is below 100.");
                }
            }
        }

        // Case 15 - Full Balance Top-Up Flow
        public static void FullBalanceTopUpFlow ()
        {
            BankAccount selectedAccount = SelectedAccount();
            if (selectedAccount == null) return;

            if (selectedAccount.Balance < 50)
            {
                Console.WriteLine("Balance before Top-Up is: " + selectedAccount.Balance);
                double amount = 100 - selectedAccount.Balance;
                selectedAccount.Deposit(amount);

                Console.WriteLine("Balance after Top-Up is: " + selectedAccount.Balance);
            }
            else
            {
                Console.WriteLine("No top-Up is needed.");
            }

        }

        // Case 16 - Quick Account Opening [Parameterized Constructor]
        public static void QuickAccountOpening()
        {
            Console.Write("Enter Account Number:");
            int accNum;
            try
            {
                accNum = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid account number input.");
                return;
            }

            Console.Write("Enter Holder Name:");
            string name = Console.ReadLine();

            Console.Write("Enter Starting Balance:");
            double balance;
            try
            {
                balance = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid balance input.");
                return;
            }

            BankAccount newAccount = new BankAccount(accNum, name, balance);

            Console.WriteLine("Account Created Successfully!");
            Console.WriteLine("Account Number: " + newAccount.AccountNumber);
            Console.WriteLine("Holder Name: " + newAccount.HolderName);
            Console.WriteLine("Balance: " + newAccount.Balance + " OMR");
        }

        // Case 17 - Total Students Counter [Static Fields & Methods]
        public static void TotalStudentsCounter()
        {
            int total = Student.GetTotalStudents();

            Console.WriteLine("Total Student objects created in the system: " + total);
        }

        // Case 18 - Overdrawn Account Check[Read - Only Property]
        public static void OverdrawnAccountCheck()
        {
            BankAccount selectedAccount = SelectedAccount();
            if (selectedAccount == null) return;

            if (selectedAccount.IsOverdrawn)
            {
                Console.WriteLine("The account is currently OVERDRAWN.");
                Console.WriteLine("Current Balance: " + selectedAccount.Balance + " OMR");
            }
            else
            {
                Console.WriteLine("The account is NOT overdrawn.");
                Console.WriteLine("Current Balance: " + selectedAccount.Balance + " OMR");
            }
        }

        // Case 19 - Set Student Security PIN [Write-Only Property]
        public static void SetStudentSecurityPin()
        {
            Student selectedStudent = SelectedStudent();
            if (selectedStudent == null) return;

            Console.Write("Enter a 4-digit security PIN:");
            int pin;
            try
            {
                pin = int.Parse(Console.ReadLine());

                if (pin < 1000 || pin > 9999)
                {
                    Console.WriteLine("Error: The PIN must be exactly 4 digits.");
                    return;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            selectedStudent.SecurityPIN = pin;

            Console.WriteLine("Confirmation: The security PIN has been successfully set.");
        }

    }

}
