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
            
            //


        }
    }
}
