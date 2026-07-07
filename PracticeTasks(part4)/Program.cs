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
        //public static int Square(int x)
        //{
        //    int sqrt = x * x;
        //    Console.WriteLine("The square is " + sqrt);
        //    return sqrt;
        //}

        ///////////////////////////////////////////////////

        // Task 3 - Celsius to Fahrenheit 
        //public static double CelsiusToFahrenheit (double C)
        //{
        //    double F = (C * 9 / 5) + 32;
        //    Console.WriteLine("The Temperature in Fehrenheit " + F);
        //    return F;
        //}

        ///////////////////////////////////////////////////////////

        // Task 4 -  Fixed Menu Display Function 
        //public static void DisplayMenu()
        //{
        //    Console.WriteLine("1) Start");
        //    Console.WriteLine("2) Help");
        //    Console.WriteLine("3) Exit");
        //}

        ////////////////////////////////////////////////////

        // Task 5 - Even or Odd Function
        //public static bool IsEven (int num)
        //{
        //    return num % 2 == 0;
        //}

        ///////////////////////////////////////////////////////////////
        
        // Task 6 - Rectangle Area & Perimeter Functions
        public static double CalculateArea(double length, double width)
        {
            double area = length * width;
            Console.WriteLine("The Area is " + area);
            return area;
        }
        public static double CalculatePerimeter(double length, double width)
        {
            double perimeter = 2* (length + width);
            Console.WriteLine("The Perimeter is " + perimeter);
            return perimeter;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //PrintWelcome(name);
            ///////////////////////////////////////////////////////////////////////
            //Console.WriteLine("Enter a number ");
            //int x = int.Parse(Console.ReadLine());
            //Square(x);
            //////////////////////////////////////////////////////////////////////
            //Console.WriteLine("Enter the Temperature as Celsius ");
            //double C = double.Parse(Console.ReadLine());
            //CelsiusToFahrenheit(C);
            /////////////////////////////////////////////////////////////////////
            //DisplayMenu();
            /////////////////////////////////////////////////////////////////////
            //Console.WriteLine("Enter a number");
            //int num = int.Parse(Console.ReadLine());
            ////////////////////////////////////////////////////////////////////
            //if (IsEven(num))
            //{
            //    Console.WriteLine("The number is Even");
            //}
            //else
            //{
            //    Console.WriteLine("The number is Odd");
            //}
            ////////////////////////////////////////////////////////////////////
            Console.Write("Enter the Length of rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter the Width of rectangle: ");
            double width = double.Parse(Console.ReadLine());

            CalculateArea(length, width);
            CalculatePerimeter(length, width);
            
            

        }
    }
}
