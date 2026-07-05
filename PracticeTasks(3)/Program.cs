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

            Console.Write("Enter a number: ");
            float num = float.Parse(Console.ReadLine());

            double power = Math.Pow(num, 2);
            double Sqrt = Math.Sqrt(num);

            Console.WriteLine("The power of the number tp 2 is " + power + " and the square root is " + Sqrt);


        }
    }
}
