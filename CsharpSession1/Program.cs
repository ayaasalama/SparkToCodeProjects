namespace CsharpSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inputs and Outputs 

            Console.WriteLine("Hello, Spark to Code!");

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Salary:");
            float salary = float.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + name + "!");

            //////////////////////////////////////////////////////////////

            // Operations 

            Console.WriteLine("enter first number: ");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("enter second number: ");
            float secondNumber = float.Parse(Console.ReadLine());


            float additionResult = firstNumber + secondNumber;
            float subtractionResult = firstNumber - secondNumber;
            float multiplicationResult = firstNumber * secondNumber;
            float divisionResult = firstNumber / secondNumber;
            float reminderResult = firstNumber % secondNumber;
            bool comparisonResult = firstNumber == secondNumber;
            bool testResult = !(10 > 5); // false

            Console.WriteLine("Addition result: " + additionResult);
            Console.WriteLine("Subtraction result: " + subtractionResult);
            Console.WriteLine("Multiplication result: " + multiplicationResult);
            Console.WriteLine("Division result: " + divisionResult);
            Console.WriteLine("Reminder result: " + reminderResult);
            Console.WriteLine("Comparison result: " + comparisonResult);
            Console.WriteLine("Test result: " + testResult);

            ////////////////////////////////////////////////////////////////////////

            // If else Conditional Statement

            Console.WriteLine("Enter your degree: ");
            float degree = float.Parse(Console.ReadLine());

            if(degree >= 0 && degree < 50)
            {
                Console.WriteLine("Failed..");
            }
            else if(degree >= 50 && degree < 60)
            {
                Console.WriteLine("Grade: D");
            }
            else if(degree >= 60 && degree < 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (degree >= 70 && degree < 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if(degree > 80)
            {
                Console.WriteLine("Grade: A");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }

            ////////////////////////////////////////////////////////////////////

            // Switch Case Conditional Statement

            Console.WriteLine("Welcome to main menu:");
            Console.WriteLine("1.Deposite");
            Console.WriteLine("2.Withdraw");
            
            Console.WriteLine("Choose an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Deposited..");
                    break;

                case 2:
                    Console.WriteLine("Withdrawed..");
                    break;

                default:
                    Console.WriteLine("please choose a correct option");
                    break;
            }
            //////////////////////////////////////////////////////////////////
        }
    }
}
