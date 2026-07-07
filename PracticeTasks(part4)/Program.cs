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

        // Task 2 - Square Number Function
        public static int Square(int x)
        {
            int sqrt = x * x;
            Console.WriteLine("The square is " + sqrt);
            return sqrt;
        }

        ///////////////////////////////////////////////////

        // Task 3 - Celsius to Fahrenheit 
        public static double CelsiusToFahrenheit(double C)
        {
            double F = (C * 9 / 5) + 32;
            Console.WriteLine("The Temperature in Fehrenheit " + F);
            return F;
        }

        ///////////////////////////////////////////////////////////

        // Task 4 -  Fixed Menu Display Function 
        public static void DisplayMenu()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }

        ////////////////////////////////////////////////////

        // Task 5 - Even or Odd Function
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

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
            double perimeter = 2 * (length + width);
            Console.WriteLine("The Perimeter is " + perimeter);
            return perimeter;
        }

        //////////////////////////////////////////////////////////////////////////

        // Task 7 - Grade Letter Function
        public static string GetGradeLetter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        /// ////////////////////////////////////////////////////////////////////////////

        // Task 8 - Countdown Function
        public static void Countdown(int startNum)
        {
            for (int i = startNum; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        /////////////////////////////////////////////////////////////////////////

        // Task 9 - Overloaded Multiply Function

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static int Multiply(int a, int b, int c)
        {
            return a + b * c;
        }

        /////////////////////////////////////////////////////////////////////////////////////

        // Task 10 - Overloaded Area Calculator

        public static double CalculateArea(double side)
        {
            return side * side;
        }

        public static double CalculateAreaR(double Length, double Width)
        {
            return Length * Width;
        }

        /// ///////////////////////////////////////////////////////////////////////////

        // Task 11 - Function-Based Calculator
        public static double Add(double Num1, double Num2)
        {
            return Num1 + Num2;
        }
        public static double Subtract(double Num1, double Num2)
        {
            return Num1 - Num2;
        }
        public static double MultiplyNumbers(double Num1, double Num2)
        {
            return Num1 * Num2;
        }
        public static double DivideNumbers(double Num1, double Num2)
        {
            try
            {
                if (Num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                return Num1 / Num2;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }
        public static void DisplayResult(string op, double res)
        {
            Console.WriteLine(op + " Result: " + res);
        }

        /////////////////////////////////////////////////////////////////////////////

        // Task 12 - Student Report Card Generator
        public static double CalculateAverage(double score1, double score2, double score3)
        {
            return (score1 + score2 + score3) / 3.0;
        }
        public static string GetGradeLetter(double average)
        {
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80)
            {
                return "B";
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else return "F";
        }
        public static void PrintReportCard(string Studentname, double average, string grade)
        {
            Console.WriteLine("Student Name : " + Studentname);
            Console.WriteLine("Average Score: " + average);
            Console.WriteLine("Final Grade  : " + grade);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            PrintWelcome(name);

            /////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter a number ");
            int x = int.Parse(Console.ReadLine());
            Square(x);

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter the Temperature as Celsius ");
            double C = double.Parse(Console.ReadLine());
            CelsiusToFahrenheit(C);

            /////////////////////////////////////////////////////////////////////
            DisplayMenu();

            /////////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            ////////////////////////////////////////////////////////////////////
            if (IsEven(num))
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }

            ////////////////////////////////////////////////////////////////////
            Console.Write("Enter the Length of rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter the Width of rectangle: ");
            double width = double.Parse(Console.ReadLine());

            CalculateArea(length, width);
            CalculatePerimeter(length, width);

            ////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your score (0-100)");
            int userScore = int.Parse(Console.ReadLine());

            string finalGrade = GetGradeLetter(userScore);

            Console.WriteLine("Your grade letter is: " + finalGrade);

            //////////////////////////////////////////////////////////////
            Console.Write("Enter a starting number for the countdown: ");
            int startNum = int.Parse(Console.ReadLine());

            Countdown(startNum);

            /////////////////////////////////////////////////////////////////
            int intResult1 = Multiply(5, 4);
            Console.WriteLine("Result from Overload 1 (Two ints: 5 * 4): " + intResult1);

            double doubleResult = Multiply(2.5, 4.0);
            Console.WriteLine("Result from Overload 2 (Two doubles: 2.5 * 4.0): " + doubleResult);

            int intResult2 = Multiply(2, 3, 4);
            Console.WriteLine("Result from Overload 3 (Three ints: 2 * 3 * 4): " + intResult2);

            //////////////////////////////////////////////////////////////////////////////////////////
            Console.Write("Type 'square' or 'rectangle': ");
            string choice = Console.ReadLine();

            if (choice == "square")
            {
                Console.Write("Enter side: ");
                double side = double.Parse(Console.ReadLine());

                Console.WriteLine("Area: " + CalculateArea(side));
            }
            else
            {
                Console.Write("Enter length: ");
                double Length = double.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                double Width = double.Parse(Console.ReadLine());

                Console.WriteLine("Area: " + CalculateAreaR(Length, Width));
            }

            ///////////////////////////////////////////////////////////////////////////////////
            while (true)
            {
                Console.WriteLine("1) Add");
                Console.WriteLine("2) Subtract");
                Console.WriteLine("3) Multiply");
                Console.WriteLine("4) Divide");
                Console.WriteLine("5) Exit");
                Console.Write("Choice: ");
                string Menuchoice = Console.ReadLine();

                if (Menuchoice == "5") break; // Exit the loop immediately

                Console.Write("Enter first number: ");
                double Num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                double Num2 = double.Parse(Console.ReadLine());

                double result = 0;
                string opName = "";

                switch (Menuchoice)
                {
                    case "1":
                        result = Add(Num1, Num2);
                        opName = "Addition";
                        break;
                    case "2":
                        result = Subtract(Num1, Num2);
                        opName = "Subtraction";
                        break;
                    case "3":
                        result = MultiplyNumbers(Num1, Num2);
                        opName = "Multiplication";
                        break;
                    case "4":
                        result = DivideNumbers(Num1, Num2);
                        opName = "Division";
                        break;
                }

                DisplayResult(opName, result);
            }

            ///////////////////////////////////////////////////////////////////////////////
            Console.Write("Enter student's name: ");
            string Studentname = Console.ReadLine();

            Console.Write("Enter score 1: ");
            double score1 = double.Parse(Console.ReadLine());
            Console.Write("Enter score 2: ");
            double score2 = double.Parse(Console.ReadLine());
            Console.Write("Enter score 3: ");
            double score3 = double.Parse(Console.ReadLine());

            // Using matching names out here in Main
            double average = CalculateAverage(score1, score2, score3);
            string grade = GetGradeLetter(average);

            PrintReportCard(name, average, grade);


        }

    }
    
}
