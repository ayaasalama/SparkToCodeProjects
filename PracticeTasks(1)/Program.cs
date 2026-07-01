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

            //Console.WriteLine("Enter a whole number to check if it is even or odd");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number " + number + " is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number " + number + " is odd.");
            //}

            ////////////////////////////////////////////////////////////////////////////////

            // Task 4 - Voting Eligibility

            //Console.WriteLine("Voting Eligibility Checker: ");
            //Console.WriteLine("Enter your age: ");
            //int userAge = int.Parse(Console.ReadLine());

            //Console.WriteLine("Do you hold a valid national ID? (yes/no): ");
            //string input = Console.ReadLine();
            //bool hasID = input == "yes";

            //if (userAge >= 18 && hasID)
            //{
            //    Console.WriteLine("You are eligible to vote.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible to vote.");
            //}

            ///////////////////////////////////////////////////////////////////////////////

            // Task 5 - Grade Letter Lookup

            //Console.WriteLine("Enter you Grade: (A, B, C, D, or F)");
            //char grade = char.Parse(Console.ReadLine().ToUpper());

            //switch (grade)
            //{
            //    case 'A':
            //        Console.WriteLine("Excellent");
            //        break;

            //    case 'B':
            //        Console.WriteLine("Very Good");
            //        break;

            //    case 'C':
            //        Console.WriteLine("Good");
            //        break;

            //    case 'D':
            //        Console.WriteLine("Pass");
            //        break;

            //    case 'F':
            //        Console.WriteLine("Fail");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid grade");
            //        break;
            //}

            /////////////////////////////////////////////////////////////////////////////////

            // Task 6 - Temperature Converter

            //Console.WriteLine("Enter temperature in Celsius: ");
            //double C = double.Parse(Console.ReadLine());

            //double F = (C * 9 / 5) + 32;
            //Console.WriteLine("Temperature in Fahrenheit: " + F);

            //if (C < 10)
            //{
            //    Console.WriteLine("The weather classification is Cold");
            //}
            //else if (C >= 10 && C <= 30)
            //{
            //    Console.WriteLine("The weather classification is Mild");
            //}
            //else
            //{
            //    Console.WriteLine("The weather classification is Hot");
            //}

            //////////////////////////////////////////////////////////////////////////
            
            // Task 7 - Movie Ticket Pricing
            
            //Console.WriteLine("Enter your age: ");
            //int Age = int.Parse(Console.ReadLine());

            //if (Age > 0 && Age <= 12)
            //{
            //    Console.WriteLine("Age Category: Children, Ticket Price: 2.000 OMR");
            //}
            //else if (Age >= 13 && Age <= 59)
            //{
            //    Console.WriteLine("Age Category: Adults, Ticket Price: 5.000 OMR");
            //}
            //else if (Age >= 60)
            //{
            //    Console.WriteLine("Age Category: Seniors, Ticket Price: 3.000 OMR");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid age entered");
            //}

            ////////////////////////////////////////////////////////////////////////////////////////
            
            // Task 8 - Resturant Bill with Membership Discount

            //Console.WriteLine("Enter the total bill amount: ");
            //double bill = double.Parse(Console.ReadLine());

            //Console.WriteLine("Are you a member? (yes/no): ");
            //string membershipInput = Console.ReadLine();
            //bool isMember = membershipInput == "yes";

            //Console.WriteLine("Your original bill is: " + bill + " OMR");

            //if (bill > 20 && isMember)
            //{
            //    Console.WriteLine("You are eligible for a 15% discount");
            //    double finalbill = bill * 0.85;  // 100 - 15 (discount) = 85 (to pay)
            //    Console.WriteLine("Your final bill after discount is: " + finalbill + " OMR");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible for a discount");
            //    Console.WriteLine("Your final bill is: " + bill + " OMR");
            //}

            ////////////////////////////////////////////////////////////////////////////////////////
            
            // Task 9 - Day Name Finder 

            Console.WriteLine("Enter a number from 1 to 7 to find the corresponding day of the week: ");
            int dayNumber = int.Parse(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("The day is Sunday");
                    break;

                case 2:
                    Console.WriteLine("The day is Monday");
                    break;

                case 3:
                    Console.WriteLine("The day is Tuesday");
                    break;

                case 4:
                    Console.WriteLine("The day is Wednesday");
                    break;

                case 5:
                    Console.WriteLine("The day is Thursday");
                    break;

                case 6:
                    Console.WriteLine("The day is Friday");
                    break;

                case 7:
                    Console.WriteLine("The day is Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 7");
                    break;
            }

            ////////////////////////////////////////////////////////////////////////////////////////
            
            //
        }
    }
}
