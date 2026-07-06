using System.Globalization;

namespace PracticeTasks_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Absolute Difference

            //Console.Write("Enter the first number: ");
            //int num1 =int.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int num2 =int.Parse(Console.ReadLine());

            //int substract = num1 - num2;
            //Console.WriteLine("The substraction result is " + substract);
            //int absubstract = Math.Abs(substract);
            //Console.WriteLine("The positive differences: " + absubstract);

            ///////////////////////////////////////////////////////////////

            // Task 2 - Power & Root Explorer

            //Console.Write("Enter a number: ");
            //float num = float.Parse(Console.ReadLine());

            //double power = Math.Pow(num, 2);
            //double Sqrt = Math.Sqrt(num);

            //Console.WriteLine("The power of the number tp 2 is " + power + " and the square root is " + Sqrt);

            //////////////////////////////////////////////////////////////////////////////////////////////////////\

            // Task 3 - Name Formatter

            //Console.Write("Enter you full name: ");
            //string name = Console.ReadLine();

            //string upperchar = name.ToUpper();
            //Console.WriteLine("Uppercase: " + upperchar);

            //string lowerchar = name.ToLower();
            //Console.WriteLine("Lowercase: " +  lowerchar);

            //int lettercount = name.Length;
            //Console.WriteLine("Number of characters: " + lettercount);

            //////////////////////////////////////////////////////////////////////////////////////////

            // Task 4 - Subscription End Date

            DateTime startDate = DateTime.Now;
            Console.WriteLine("Start Date is: " + startDate);

            Console.Write("Enter number of days of a free trial: ");
            int numDays = int.Parse(Console.ReadLine());

            DateTime endDate = startDate.AddDays(numDays);
            Console.WriteLine("The End date is: " + endDate);

            string subend = endDate.ToString("yyyy-MM-dd");
            Console.WriteLine("The End date in yyyy-MM-dd format: " + subend); 


        }
    }
}
