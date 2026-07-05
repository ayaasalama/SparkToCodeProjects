using System.Security.Principal;

namespace FunctionsPractice_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // built in functions call
            // classname.functonname(parameters)

            Console.WriteLine("hello");
            Console.Clear();


            double result = Math.Pow(2, 3);   // 2^3=8
            Console.WriteLine(result);
            Console.WriteLine(Math.Sqrt(16));  // 4

            ////////////////////////////////////////////////////////////////////

            Console.WriteLine("Enter a number");
            float userInput = float.Parse(Console.ReadLine());

            double r1 = Math.Cos(userInput);
            Console.WriteLine(r1);

            //////////////////////////////////////////////////////////////////

            Console.WriteLine("Enter base number");
            float baseNum = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter power number");
            float powerNum = float.Parse(Console.ReadLine());

            double r2 = Math.Pow(baseNum, powerNum);
            Console.WriteLine(r2);

            ///////////////////////////////////////////////////////////////////

            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);

            DateTime startsub = DateTime.Today;
            Console.WriteLine(startsub);
            DateTime endsub = startsub.AddDays(7);

            ///////////////////////////////////////////////////////////////////

            string word = "Hello, world!";
            int length = word.Length;
            Console.WriteLine(length);

            string sub = word.Substring(0, 6);
            Console.WriteLine(sub);

            string upperword = word.ToUpper();
            Console.WriteLine(upperword);
            string lowerword = word.ToLower();
            Console.WriteLine(lowerword);

            string name = "aya";
            Console.WriteLine("Enter your name");
            string input = Console.ReadLine();

            if (input.ToUpper() == name.ToUpper())       
            {
                Console.WriteLine("Welcome " + name);
            }
            else
            {
                Console.WriteLine("invalid, please try again");
            }

            bool cont = name.Contains('e');
            Console.WriteLine(cont);

        }
    }
}
