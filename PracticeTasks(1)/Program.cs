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

            //Console.WriteLine("Enter a number from 1 to 7 to find the corresponding day of the week: ");
            //int dayNumber = int.Parse(Console.ReadLine());

            //switch (dayNumber)
            //{
            //    case 1:
            //        Console.WriteLine("The day is Sunday");
            //        break;

            //    case 2:
            //        Console.WriteLine("The day is Monday");
            //        break;

            //    case 3:
            //        Console.WriteLine("The day is Tuesday");
            //        break;

            //    case 4:
            //        Console.WriteLine("The day is Wednesday");
            //        break;

            //    case 5:
            //        Console.WriteLine("The day is Thursday");
            //        break;

            //    case 6:
            //        Console.WriteLine("The day is Friday");
            //        break;

            //    case 7:
            //        Console.WriteLine("The day is Saturday");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid input. Please enter a number from 1 to 7");
            //        break;
            //}

            ////////////////////////////////////////////////////////////////////////////////////////

            // Task 10 - Mini Calculator

            //Console.WriteLine("Enter the first number: ");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number: ");
            //double num2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the operation (+, -, *, /, %): ");
            //char operation = char.Parse(Console.ReadLine());

            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine("Result of the addition: " + (num1 + num2));
            //        break;

            //    case '-':
            //        Console.WriteLine("Result of the subtraction: " + (num1 - num2));
            //        break;

            //    case '*':
            //        Console.WriteLine("Result of the multiplication: " + (num1 * num2));
            //        break;

            //    case '/':
            //        if (num2 != 0)
            //        {
            //            Console.WriteLine("Result of the division: " + (num1 / num2));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Cannot divide by zero");
            //        }
            //        break;

            //    case '%':
            //        if (num2 != 0)
            //        {
            //            Console.WriteLine("Result of the modulus: " + (num1 % num2));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Cannot perform modulus by zero");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid operator. Please enter one of the following: +, -, *, /, %");
            //        break;
            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 11 - Loan Eligibility System 

            //Console.WriteLine("Enter your age: ");
            //int applicableAge = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your monthly income: ");
            //double monthlyIncome = double.Parse(Console.ReadLine());
            //Console.WriteLine("Do you have any existing loans? (yes/no): ");
            //string existingLoansInput = Console.ReadLine();
            //bool hasExistingLoans = existingLoansInput == "yes";

            //if (applicableAge >= 21 && applicableAge <= 60 && monthlyIncome >= 400 && !hasExistingLoans)
            //{
            //    Console.WriteLine("You are eligible for a loan.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible for a loan.");
            //}

            //if (applicableAge < 21 || applicableAge > 60)
            //{
            //    Console.WriteLine("Reason: Age must be between 21 and 60");
            //}

            //if (monthlyIncome < 400)
            //{
            //    Console.WriteLine("Reason: Monthly income must be at least 400 OMR");
            //}

            //if (hasExistingLoans)
            //{
            //    Console.WriteLine("Reason: You must not have any existing loans");
            //}

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 12 - Shipping Cost Calculator

            //Console.WriteLine("Enter the weight of the package in kilograms: ");
            //double weight = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the destination region:");
            //Console.WriteLine("A. Local");
            //Console.WriteLine("B. National");
            //Console.WriteLine("C. International");
            //char region = char.Parse(Console.ReadLine().ToUpper());

            //double cost;
            //double totalCost;

            //switch (region)
            //{
            //    case 'A':
            //        cost = 1.000;
            //        Console.WriteLine("Base shipping cost: " + cost + " OMR");

            //        if (weight > 5 && weight <= 10)
            //        {
            //            Console.WriteLine("Extra charge 2.000 OMR");
            //            totalCost = cost + 2.000;
            //            Console.WriteLine("Total shipping cost: " + totalCost + " OMR");

            //        }
            //        else if (weight > 10)
            //        {
            //            Console.WriteLine("Extra charge 5.000 OMR");
            //            totalCost = cost + 5.000;
            //            Console.WriteLine("Total shipping cost: " + totalCost + " OMR");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No extra charge");
            //            Console.WriteLine("Total shipping cost: " + cost + " OMR");
            //        }
            //        break;

            //    case 'B':
            //        cost = 3.000;
            //        Console.WriteLine("Base shipping cost: " + cost + " OMR");

            //        if (weight > 5 && weight <= 10)
            //        {
            //            Console.WriteLine("Extra charge 2.000 OMR");
            //            totalCost = cost + 2.000;
            //            Console.WriteLine("Total shipping cost: " + totalCost + " OMR");

            //        }
            //        else if (weight > 10)
            //        {
            //            Console.WriteLine("Extra charge 5.000 OMR");
            //            totalCost = cost + 5.000;
            //            Console.WriteLine("Total shipping cost: " + totalCost + " OMR");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No extra charge");
            //            Console.WriteLine("Total shipping cost: " + cost + " OMR");
            //        }
            //        break;

            //    case 'C':
            //        cost = 7.000;
            //        Console.WriteLine("Base shipping cost: " + cost + " OMR");

            //        if (weight > 5 && weight <= 10)
            //        {
            //            Console.WriteLine("Extra charge 2.000 OMR");
            //            totalCost = cost + 2.000;
            //            Console.WriteLine("Total shipping cost: " + totalCost + " OMR");

            //        }
            //        else if (weight > 10)
            //        {
            //            Console.WriteLine("Extra charge 5.000 OMR");
            //            totalCost = cost + 5.000;
            //            Console.WriteLine("Total shipping cost: " + totalCost + " OMR");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No extra charge");
            //            Console.WriteLine("Total shipping cost: " + cost + " OMR");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid region entered. Please enter A, B, or C");
            //        break;

            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 13 - Triangle Type Classifier

            //Console.WriteLine("Enter the lengths of the three sides of the triangle:");
            //Console.Write("Side 1: ");
            //double side1 = double.Parse(Console.ReadLine());
            //Console.Write("Side 2: ");
            //double side2 = double.Parse(Console.ReadLine());
            //Console.Write("Side 3: ");
            //double side3 = double.Parse(Console.ReadLine());

            //if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            //{
            //    Console.WriteLine("The triangle is valid.");

            //    if (side1 == side2 && side1 == side3)
            //    {
            //        Console.WriteLine("The triangle is equilateral (all sides equal)");
            //    }
            //    else if (side1 == side2 || side1 == side3 || side2 == side3)
            //    {
            //        Console.WriteLine("The triangle is isosceles (two sides equal)");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The triangle is scalene (no sides equal)");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The triangle is not valid.");
            //}

            /////////////////////////////////////////////////////////////////////////////////////

            // Task 14 - Online Store Checkout

            Console.WriteLine("Choose a product code to purchase:");
            Console.WriteLine("1. Headphones - 8.500 OMR");
            Console.WriteLine("2. Keyboard - 12.000 OMR");
            Console.WriteLine("3. Mouse - 5.000 OMR");

            Console.Write("Product code: ");
            int productCode = int.Parse(Console.ReadLine());
                        
            double unitprice;
            double subtotal;
            double discount; 
            double afterdiscount; 
            double tax; 
            double finalTotal;

            if (productCode == 1 || productCode == 2 || productCode == 3)
            {
                Console.Write("Enter the quantity you want to purchase: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.Write("Do you have a coupon? (yes/no): ");
                string couponInput = Console.ReadLine().ToLower();
                bool hasCoupon = couponInput == "yes";

                switch (productCode)
                {
                    case 1:
                        unitprice = 8.500;

                        Console.WriteLine("Product: Headphones, Unit Price: " + unitprice + " OMR");
                        Console.WriteLine("Quantity chosen is " + quantity);

                        subtotal = unitprice * quantity;
                        Console.WriteLine("Subtotal: " + subtotal + " OMR");

                        if (hasCoupon && subtotal > 20)
                        {
                            Console.WriteLine("You are eligible for a 10% discount");
                            discount = subtotal * 0.1; // 10% discount
                            Console.WriteLine("Discount amount: " + discount + " OMR");
                            afterdiscount = subtotal * 0.9; // 10% discount means 90% to pay
                            tax = afterdiscount * 0.05; // 5% tax
                            Console.WriteLine("Tax amount: " + tax + " OMR");
                            finalTotal = afterdiscount + tax;
                            Console.WriteLine("Final total after discount and tax: " + finalTotal + " OMR");
                        }
                        else
                        {
                            Console.WriteLine("You are not eligible for a discount");
                            tax = subtotal * 0.05; // 5% tax
                            Console.WriteLine("Tax amount: " + tax + " OMR");
                            finalTotal = subtotal + tax;
                            Console.WriteLine("Final total after tax: " + finalTotal + " OMR");
                        }
                        break;

                    case 2:
                        unitprice = 12.000;

                        Console.WriteLine("Product: Keyboard, Unit Price: " + unitprice + " OMR");
                        Console.WriteLine("Quantity chosen is " + quantity);

                        subtotal = unitprice * quantity;
                        Console.WriteLine("Subtotal: " + subtotal + " OMR");

                        if (hasCoupon && subtotal > 20)
                        {
                            Console.WriteLine("You are eligible for a 10% discount");
                            discount = subtotal * 0.1; // 10% discount
                            Console.WriteLine("Discount amount: " + discount + " OMR");
                            afterdiscount = subtotal * 0.9; // 10% discount means 90% to pay
                            tax = afterdiscount * 0.05; // 5% tax
                            Console.WriteLine("Tax amount: " + tax + " OMR");
                            finalTotal = afterdiscount + tax;
                            Console.WriteLine("Final total after discount and tax: " + finalTotal + " OMR");
                        }
                        else
                        {
                            Console.WriteLine("You are not eligible for a discount");
                            tax = subtotal * 0.05; // 5% tax
                            Console.WriteLine("Tax amount: " + tax + " OMR");
                            finalTotal = subtotal + tax;
                            Console.WriteLine("Final total after tax: " + finalTotal + " OMR");
                        }
                        break;

                    case 3:

                        unitprice = 5.000;

                        Console.WriteLine("Product: Mouse, Unit Price: " + unitprice + " OMR");
                        Console.WriteLine("Quantity chosen is " + quantity);

                        subtotal = unitprice * quantity;
                        Console.WriteLine("Subtotal: " + subtotal + " OMR");

                        if (hasCoupon && subtotal > 20)
                        {
                            Console.WriteLine("You are eligible for a 10% discount");
                            discount = subtotal * 0.1; // 10% discount
                            Console.WriteLine("Discount amount: " + discount + " OMR");
                            afterdiscount = subtotal * 0.9; // 10% discount means 90% to pay
                            tax = afterdiscount * 0.05; // 5% tax
                            Console.WriteLine("Tax amount: " + tax + " OMR");
                            finalTotal = afterdiscount + tax;
                            Console.WriteLine("Final total after discount and tax: " + finalTotal + " OMR");
                        }
                        else
                        {
                            Console.WriteLine("You are not eligible for a discount");
                            tax = subtotal * 0.05; // 5% tax
                            Console.WriteLine("Tax amount: " + tax + " OMR");
                            finalTotal = subtotal + tax;
                            Console.WriteLine("Final total after tax: " + finalTotal + " OMR");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid product code entered. Please enter 1, 2, or 3");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Invalid product code entered. Please enter 1, 2, or 3");
            }
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            //
            
        }
    }
}
