using System.Xml.Linq;

namespace MiniCompoundProject_1_
{
    internal class Program
    {
        //Shared Data Storage - declared at Class level 

        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. Search Accounts by Customer Name");
                Console.WriteLine("7. Close an Account");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue;

                }

                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        SearchbyCustomerName();
                        break;
                    case 7:
                        CloseAccount();
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }


            }
        }

        static void AddAccount()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();
            Console.Write("Enter new account number: ");
            string accountNum = Console.ReadLine();

            if (accountNumbers.Contains(accountNum))
            {
                Console.WriteLine("Error: Account number already in use!");
                return;
            }

            Console.Write("Enter an initial deposit amount: ");
            double initDeposit = double.Parse(Console.ReadLine());

            if (initDeposit < 0)
            {
                Console.WriteLine("Error: Initial deposit cannot be negative!");
                return;
            }

            customerNames.Add(name);
            accountNumbers.Add(accountNum);
            balances.Add(initDeposit);

            Console.WriteLine("\n--- Account Created Successfully ---");
            Console.WriteLine("Customer Name : " + name);
            Console.WriteLine("Account Number: " + accountNum);
            Console.WriteLine("Balance       : " + initDeposit.ToString("F2") + " OMR");
        }



    }
}