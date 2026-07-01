namespace PracticeTasks_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Personal Info Card

            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your age");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your height in meters");
            //double height = double.Parse(Console.ReadLine());
            //Console.WriteLine("Are you a student? (True/False)");
            //bool isStudent = bool.Parse(Console.ReadLine());

            //Console.WriteLine("Name: " + name + ", Age: " + age + ", Height: " + height + ", Student: " + isStudent);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 2 - Rectangle Calculator

            //Console.WriteLine("Enter the length of the rectangle");
            //double length = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the width of the rectangle");
            //double width = double.Parse(Console.ReadLine());

            //double area = length * width;
            //double perimeter = 2 * (length + width);

            //Console.WriteLine("Area= length * width= " + area );
            //Console.WriteLine("Perimeter= 2 * (length + width)= " + perimeter);

            //////////////////////////////////////////////////////////////////////////////

            // Task 3 - Even or Odd Checker

            Console.WriteLine("Enter a whole number to check if it is even or odd");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number " + number + " is even.");
            }
            else
            {
                Console.WriteLine("The number " + number + " is odd.");
            }

            ////////////////////////////////////////////////////////////////////////////////
            
            //
        }
}
}
