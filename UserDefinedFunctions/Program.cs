namespace UserDefinedFunctions
{
    internal class Program
    {
        // User Defined Functions
        
        //Function Implementation
        
        public static void PrintMainMenu() // method head (no return, no parameter)
        {
            // method body
            Console.WriteLine("Main Menu");
            Console.WriteLine("0. Add Account Info");
            Console.WriteLine("1. View Account Info");
            Console.WriteLine("2. Edit Account Info");
            Console.WriteLine("3. Deposite Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Show Balance");
            Console.WriteLine("6. Exit");
        }

        public static void PrintWelcomeName(string name) // no return, with parameter
        {
            Console.WriteLine("Welcome to the application " + name);
        }

        public static DateTime GetTodaysDate() // return type is DateTime but with no parameter
        {
            Console.WriteLine(DateTime.Today);
            return DateTime.Today;
        }
        
        public static int AddNumbers(int num1, int num2) // return type is int aand with parameters
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
            return sum;
        }

        // main method
        static void Main(string[] args)
        {
            // Function Call
            PrintWelcomeName("Aya");

            PrintMainMenu();

            GetTodaysDate();

            AddNumbers(3, 10);

            
        }
    }
}
