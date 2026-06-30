namespace CsharpSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Spark to Code!");

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Salary:");
            float salary = float.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + name + "!");

        }
    }
}
