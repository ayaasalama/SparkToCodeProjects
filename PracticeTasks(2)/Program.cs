namespace PracticeTasks_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Countdown Timer

            Console.WriteLine("Countdown Timer");
            Console.Write("Enter the Starting number: ");
            int count = int.Parse(Console.ReadLine());
            int i;

            for (i = count; i >=1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");

            ////////////////////////////////////////////////////////////
            
            //
        }
    }
}
