using System.Xml.Linq;

namespace PracticeTasks_part4_
{
    internal class Program
    {
        // Task 1 - Personalized Welcome Function
        public static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome " + name);
        }

        //////////////////////////////////////////////////////
        
        //
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            PrintWelcome(name);
        }
    }
}
