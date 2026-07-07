using System.Xml.Linq;

namespace PracticeTasks_part4_
{
    internal class Program
    {
        // Task 1 - Personalized Welcome Function
        //public static void PrintWelcome(string name)
        //{
        //    Console.WriteLine("Welcome " + name);
        //}

        //////////////////////////////////////////////////////
        
        // Task 2 - Square Number Function
        public static int Square(int x)
        {
            int sqrt = x * x;
            Console.WriteLine("The square is " + sqrt);
            return sqrt;
            
        }
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //PrintWelcome(name);

            Console.WriteLine("Enter a number ");
            int x = int.Parse(Console.ReadLine());
            Square(x);


        }
    }
}
