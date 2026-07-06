using System.Globalization;

namespace PracticeTasks_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Absolute Difference

            //Console.Write("Enter the first number: ");
            //int num1 =int.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int num2 =int.Parse(Console.ReadLine());

            //int substract = num1 - num2;
            //Console.WriteLine("The substraction result is " + substract);
            //int absubstract = Math.Abs(substract);
            //Console.WriteLine("The positive differences: " + absubstract);

            ///////////////////////////////////////////////////////////////

            // Task 2 - Power & Root Explorer

            //Console.Write("Enter a number: ");
            //float num = float.Parse(Console.ReadLine());

            //double power = Math.Pow(num, 2);
            //double Sqrt = Math.Sqrt(num);

            //Console.WriteLine("The power of the number tp 2 is " + power + " and the square root is " + Sqrt);

            //////////////////////////////////////////////////////////////////////////////////////////////////////\

            // Task 3 - Name Formatter

            //Console.Write("Enter you full name: ");
            //string name = Console.ReadLine();

            //string upperchar = name.ToUpper();
            //Console.WriteLine("Uppercase: " + upperchar);

            //string lowerchar = name.ToLower();
            //Console.WriteLine("Lowercase: " +  lowerchar);

            //int lettercount = name.Length;
            //Console.WriteLine("Number of characters: " + lettercount);

            //////////////////////////////////////////////////////////////////////////////////////////

            // Task 4 - Subscription End Date

            //DateTime startDate = DateTime.Now;
            //Console.WriteLine("Start Date is: " + startDate);

            //Console.Write("Enter number of days of a free trial: ");
            //int numDays = int.Parse(Console.ReadLine());

            //DateTime endDate = startDate.AddDays(numDays);
            //Console.WriteLine("The End date is: " + endDate);

            //string subend = endDate.ToString("yyyy-MM-dd");
            //Console.WriteLine("The End date in yyyy-MM-dd format: " + subend); 

            //////////////////////////////////////////////////////////////////////////////////////////

            // Task 5 - Grade Rounding System

            //Console.WriteLine("Enter your raw exam score (decimal)");
            //double rawScore = double.Parse(Console.ReadLine());

            //double roundScore = Math.Round(rawScore, 0);
            //Console.WriteLine("The rounded score is: " + roundScore);

            //if (roundScore >= 60)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}

            ///////////////////////////////////////////////////////////////////////////////

            // Task 6 - Password Strength Checker

            //Console.WriteLine("Enter a password");
            //string password = Console.ReadLine();

            //int passLength = password.Length;

            //string lowerpass = password.ToLower();
            //bool hasForbidden = lowerpass.Contains("password");

            //if (hasForbidden || passLength < 8)
            //{
            //    Console.WriteLine("The password is weak");

            //    if (hasForbidden)
            //    {
            //        Console.WriteLine("It has the word 'password' in it");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The password is less than 8 characters");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The password is Strong");
            //}

            //////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 7 - Clean Name Comparator

            //Console.WriteLine("Enter a name: ");
            //string Firstname = Console.ReadLine();

            //Console.WriteLine("Enter the name again");
            //string Secondname = Console.ReadLine();

            //string cleanFirstname = Firstname.Trim().ToUpper();
            //string cleanSecondname = Secondname.Trim().ToUpper();

            //if (cleanFirstname == cleanSecondname)
            //{
            //    Console.WriteLine("Match.");
            //}
            //else
            //{
            //    Console.WriteLine("No Match.");
            //}

            ////////////////////////////////////////////////////////////////

            // Task 8 - Membership Expiry Checker

            //Console.WriteLine("Enter your membership start date (yyyy-mm-dd): ");
            //DateTime membershipstart = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the number of valid membership days: ");
            //int validDays = int.Parse(Console.ReadLine());

            //DateTime expireDate = membershipstart.AddDays(validDays);

            //DateTime today = DateTime.Today;

            //if (expireDate >= today)
            //{
            //    Console.WriteLine("Active");
            //}
            //else
            //{
            //    Console.WriteLine("Expired");
            //}

            ///////////////////////////////////////////////////////////////////////////

            // Task 9 - Round Up/ Round Down Explorer

            //Console.Write("Enter a decimal number: ");
            //float decNum = float.Parse(Console.ReadLine());
            //Console.WriteLine("The original number " + decNum);

            //double wholeNum = Math.Round(decNum, 0);
            //Console.WriteLine("The nearest whole number: " + wholeNum);

            //double roundup = Math.Ceiling(decNum);
            //Console.WriteLine("Always Rounded Up: " + roundup);

            //double roundDown = Math.Floor (decNum);
            //Console.WriteLine("Always Rounded Down: " + roundDown);

            /////////////////////////////////////////////////////////////////////

            // Task 10 - word Position Finder

            //Console.WriteLine("Enter a full sentence: ");
            //string sentence = Console.ReadLine();

            //Console.WriteLine("Enter a single word to search for: ");
            //string word = Console.ReadLine();

            //int firstIndex = sentence.IndexOf(word);
            //int lastIndex = sentence.LastIndexOf(word);

            //if (firstIndex == -1)
            //{
            //    Console.WriteLine("The word is not Found");
            //}
            //else
            //{
            //    Console.WriteLine("Word Found");
            //    Console.WriteLine("First appearance position: " + firstIndex);
            //    Console.WriteLine("Last appearance position: " + lastIndex);
            //}

            //////////////////////////////////////////////////////////////////

            // Task 11 - One-Time Password (OTP) Generator

            Random random = new Random();
            int generatedOTP = random.Next(1000, 10000);

            Console.WriteLine("Your 4-digit OTP is " + generatedOTP);

            int maxAttemps = 3;
            bool isVerified = false;

            for (int attempt = 1; attempt <= maxAttemps; attempt++)
            {
                try
                {
                    Console.WriteLine("Enter the Generated OTP:");
                    int userOTP = int.Parse(Console.ReadLine());

                    if (userOTP == generatedOTP)
                    {
                        Console.WriteLine("Verified");
                        isVerified = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Verification Failed");
                    }

                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid Input");
                }

            }



        }

    }
    
}
