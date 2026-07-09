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
                Console.WriteLine("\n====== Welcome to Spark Bank ======");
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

        public static void AddAccount()
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

        public static void DepositMoney()
        {
            Console.WriteLine("Enter account number: ");
            string accountNum = Console.ReadLine();

            int FoundAccount = accountNumbers.IndexOf(accountNum);
            if (FoundAccount == -1)
            {
                Console.WriteLine("Account Not Found!");
                return;
            }

            Console.Write("Enter deposit amount: ");
            double deposit = double.Parse(Console.ReadLine());
            if (deposit <= 0)
            {
                Console.WriteLine("Error: Deposit cannot be negative!");
                return;
            }

            balances[FoundAccount] += deposit;
            Console.WriteLine("\nThe updated balance is: " + balances[FoundAccount].ToString("F2") + " OMR");
        }

        public static void WithdrawMoney()
        {
            Console.WriteLine("Enter account number: ");
            string accountNum = Console.ReadLine();

            int FoundAccount = accountNumbers.IndexOf(accountNum);
            if (FoundAccount == -1)
            {
                Console.WriteLine("Account Not Found!");
                return;
            }

            Console.Write("Enter withdraw amount: ");
            double withdraw = double.Parse(Console.ReadLine());
            if (withdraw <= 0 || withdraw > balances[FoundAccount])
            {
                if (withdraw > balances[FoundAccount])
                {
                    Console.WriteLine("Balance insufficient!");
                }
                else
                {
                    Console.WriteLine("Error: Withdraw cannot be negative!");
                }
                return;
            }

            balances[FoundAccount] -= withdraw;
            Console.WriteLine("\nThe updated balance is: " + balances[FoundAccount].ToString("F2") + " OMR");
        }

        public static void ShowBalance()
        {
            Console.WriteLine("Enter account number: ");
            string accountNum = Console.ReadLine();

            int FoundAccount = accountNumbers.IndexOf(accountNum);
            if (FoundAccount == -1)
            {
                Console.WriteLine("Account Not Found!");
                return;
            }

            Console.WriteLine("\nCustomer Name : " + customerNames[FoundAccount]);
            Console.WriteLine("Account Number: " + accountNumbers[FoundAccount]);
            Console.WriteLine("Balance       : " + balances[FoundAccount].ToString("F2") + " OMR");
        }

        public static void TransferAmount()
        {
            Console.WriteLine("Enter Sender's account number: ");
            string SenderAccNum = Console.ReadLine();
            Console.WriteLine("Enter Receiver's account number: ");
            string ReceiverAccNum = Console.ReadLine();

            int SenderFoundAccount = accountNumbers.IndexOf(SenderAccNum);
            int ReceiverFoundAccount = accountNumbers.IndexOf(ReceiverAccNum);

            if (SenderFoundAccount == -1 || ReceiverFoundAccount == -1)
            {
                if (SenderFoundAccount == -1)
                {
                    Console.WriteLine("Sender's Account Not Found");
                    return;
                }

                if (ReceiverFoundAccount == -1)
                {
                    Console.WriteLine("Receiver's Account Not Found!");
                    return;
                }
            }

            Console.Write("Enter transfer amount: ");
            double transfer = double.Parse(Console.ReadLine());
            if (transfer <= 0 || transfer > balances[SenderFoundAccount])
            {
                if (transfer > balances[SenderFoundAccount])
                {
                    Console.WriteLine("Balance insufficient!");
                }
                else
                {
                    Console.WriteLine("Error: Transfer amount must be positive!");
                }
                return;
            }

            balances[SenderFoundAccount] -= transfer;
            balances[ReceiverFoundAccount] += transfer;

            Console.WriteLine("\nThe Sender's Updated balance is: " + balances[SenderFoundAccount] + " OMR");
            Console.WriteLine("The Receiver's Updated balance is: " + balances[ReceiverFoundAccount] + " OMR");
        }

        public static void SearchbyCustomerName()
        {
            Console.Write("Enter customer name to search: ");
            string searchName = Console.ReadLine();
            bool foundCustomer = false;

            int i;
            for ( i = 0; i < customerNames.Count; i++)
            {
                if (customerNames[i].ToLower() == searchName.ToLower())
                {
                    Console.WriteLine("\nFound Account for " + customerNames[i]);
                    Console.WriteLine("Account Number: " + accountNumbers[i]);
                    Console.WriteLine("Balance       : " + balances[i].ToString("F2") + " OMR");
                    foundCustomer = true;
                }
            }

            if (!foundCustomer)
            {
                Console.WriteLine("No accounts found under that name");
            }

        }

        public static void CloseAccount()
        {
            Console.WriteLine("Enter Account Number: ");
            string accountNum = Console.ReadLine();

            int FoundAccount = accountNumbers.IndexOf(accountNum);
            if (FoundAccount == -1)
            {
                Console.WriteLine("Account Not Found!");
                return;
            }

            if (balances[FoundAccount] > 0)
            {
                Console.WriteLine("\nCannot close account. Please withdraw the remaining balance first!");
                return;
            }

            customerNames.RemoveAt(FoundAccount);
            accountNumbers.RemoveAt(FoundAccount);
            balances.RemoveAt(FoundAccount);

            Console.WriteLine("\nAccount Successfully Closed!");
        }

    }
}