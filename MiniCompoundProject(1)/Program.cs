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

            }


        }
}
