namespace PracticeTasks_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Countdown Timer

            //Console.WriteLine("Countdown Timer");
            //Console.Write("Enter the Starting number: ");
            //int count = int.Parse(Console.ReadLine());
            //int i;

            //for (i = count; i >=1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Liftoff!");

            ////////////////////////////////////////////////////////////

            // Task 2 - Sum of Numbers 1 to N

            //Console.WriteLine("Sum of Numbers 1 to N");
            //Console.WriteLine("Enter the a positive N value");
            //int n = int.Parse(Console.ReadLine());
            //int a;
            //int sum = 0;

            //if (n > 0)
            //{
            //    for (a = 1; a <= n; a++)
            //    {
            //        sum += a;
            //    }
            //    Console.WriteLine("The final sum of numbers from 1 to " + n + " is: " + sum);

            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive number.");
            //}

            /////////////////////////////////////////////////////////////////////////////////////

            // Task 3 - Multiplication Table

            //Console.WriteLine("Multiplication Table");
            //Console.Write("Enter a number to generate its multiplication table:");
            //int number = int.Parse(Console.ReadLine());

            //for (int m = 0; m <= 10; m++)
            //{
            //    Console.WriteLine(number + " x " + m + " = " + (number * m));
            //}

            //////////////////////////////////////////////////////////////////////////////////////

            // Task 4 - Password Retry

            //bool exit = false;
            //string truePassword = "Spark2026";
            //string password;

            //while (exit == false)
            //{
            //    Console.WriteLine("Enter your password:");
            //    password = Console.ReadLine();

            //    if (truePassword == password)
            //    {
            //        Console.WriteLine("Access granted");
            //        exit = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect password, try again");
            //    }
            //}

            ////////////////////////////////////////////////////////////////////////////////////

            // Task 5 - Number Guessing Game

            //int secretNumber = 42;
            //int userGuess;
            //bool exitdesision = false;
            //int counter = 0;

            //do
            //{
            //    Console.WriteLine("Guess the Secret Number");
            //    Console.Write("Enter your guess:");
            //    userGuess = int.Parse(Console.ReadLine());
            //    counter++;

            //    if (userGuess > secretNumber + 10)
            //    {
            //        Console.WriteLine("Too high! Guess again");
            //    }
            //    else if (userGuess < secretNumber - 10)
            //    {
            //        Console.WriteLine("Too low! Guess again");
            //    }
            //    else if (userGuess <= secretNumber + 10 && userGuess >= secretNumber - 10 && userGuess != secretNumber)
            //    {
            //        Console.WriteLine("Close! Guess again");
            //    }
            //    else if (userGuess == secretNumber)
            //    {
            //        Console.WriteLine("Congratulations! You guessed the secret number in " + counter + " attempts");
            //        exitdesision = true;
            //    }

            //} while (exitdesision == false);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 6 - Safe Division Calculator

            Console.WriteLine("Safe Division Calculator");
            int divisionResult;

            try
            {
                Console.Write("Enter the first number:");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number:");
                int num2 = int.Parse(Console.ReadLine());

                divisionResult = num1 / num2;

                Console.WriteLine("The result of the division is: " + divisionResult);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by Zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            
            ///////////////////////////////////////////////////////////////////////////////////////////////////////


        }
    }
}
