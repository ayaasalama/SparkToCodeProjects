namespace PracticeTasks_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Countdown Timer

            //Console.WriteLine("Countdown Timer");
            //Console.Write("Enter the Starting number: ");
            //int count = int.Parse(Console.ReadLine());
            //int i;

            //for (i = count; i >=1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Liftoff!");

            ////////////////////////////////////////////////////////////

            // Task 2 - Sum of Numbers 1 to N

            Console.WriteLine("Sum of Numbers 1 to N");
            Console.WriteLine("Enter the a positive N value");
            int n = int.Parse(Console.ReadLine());
            int a;
            int sum = 0;

            if (n > 0)
            {
                for (a = 1; a <= n; a++)
                {
                    sum += a;
                }
                Console.WriteLine("The final sum of numbers from 1 to " + n + " is: " + sum);

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }

            /////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
