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

            //Console.WriteLine("Safe Division Calculator");
            //int divisionResult;

            //try
            //{
            //    Console.Write("Enter the first number:");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter the second number:");
            //    int num2 = int.Parse(Console.ReadLine());

            //    divisionResult = num1 / num2;

            //    Console.WriteLine("The result of the division is: " + divisionResult);

            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by Zero");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 7 - Repeating Menu with Exit Option

            //bool Exit = false;

            //Console.WriteLine("Choose an option from the menu:");
            //Console.WriteLine("1. Say hello");
            //Console.WriteLine("2. Show Current Time-of-day Greeting");
            //Console.WriteLine("3. Exit");

            //int option;

            //while (Exit == false)
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter your option:");
            //        option = int.Parse(Console.ReadLine());

            //        switch (option)
            //        {
            //            case 1:
            //                Console.WriteLine("Hello!");
            //                break;

            //            case 2:
            //                Console.WriteLine("Good Evening");
            //                break;

            //            case 3:
            //                Console.WriteLine("Exiting the program...");
            //                Exit = true;
            //                break;

            //            default:
            //                Console.WriteLine("Invalid option. Please choose a valid option from the menu.");
            //                break;

            //        }

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number.");
            //        continue;
            //    }

            //}

            //////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 8 - Sum of Even Numbers Only

            //Console.WriteLine("Sum of Even Numbers Only");
            //Console.WriteLine("Enter a positive N value");
            //int num = int.Parse(Console.ReadLine());

            //int c;
            //int sum = 0;

            //for (c = 1; c <= num; c++)
            //{
            //    if (c % 2 == 0)
            //    {
            //        sum += c;
            //    }
            //}
            //Console.WriteLine("The final sum of even numbers from 1 to " + num + " is: " + sum);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 9 - Validated Positive Number Input

            //bool exitloop = false;
            //int positiveNumber = 0;
            //int nsum = 0;

            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter a positive number: ");
            //        positiveNumber = int.Parse(Console.ReadLine());

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number.");
            //        continue;
            //    }

            //    if (positiveNumber > 0)
            //    {
            //        Console.WriteLine("You entered a positive number: " + positiveNumber);
            //        exitloop = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a positive number.");
            //    }

            //} while (exitloop == false);

            //for (int p = 1; p <= positiveNumber; p++)
            //{
            //    nsum += p;
            //}
            //Console.WriteLine("The final sum of numbers from 1 to " + positiveNumber + " is: " + nsum);

            ///////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 10 - Simple ATM Simulation

            int correctPass = 1234;
            int userPass = 0;
            double startBalance = 1000.000;
            int t;
            bool exitATM = false;
            bool accessGranted = false;

            for (t = 2; t >= 0; t--)
            {
                Console.WriteLine("Enter your PIN:");
                try
                {
                    userPass = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number");
                    Console.WriteLine("Incorrect PIN. You have " + t + " attempts left");
                    continue;
                }

                if (userPass == correctPass)
                {
                    accessGranted = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect PIN. You have " + t + " attempts left");
                }
            }

            if (accessGranted)
            {
                Console.WriteLine("Access granted");

                while (exitATM == false)
                {
                    Console.WriteLine("Choose an option from the menu:");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Check balance");
                    Console.WriteLine("4. Exit");

                    int choice;

                    try
                    {
                        Console.Write("Enter your option:");
                        choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                double depositAmount;

                                try
                                {
                                    Console.Write("Enter the amount to deposit: ");
                                    depositAmount = double.Parse(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid number");
                                    continue;
                                }

                                if (depositAmount > 0)
                                {
                                    startBalance += depositAmount;
                                    Console.WriteLine("Deposit successful. New balance: " + startBalance + " OMR");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid deposit amount. Please enter a positive number");
                                }
                                break;

                            case 2:
                                double withdrawAmount;

                                try
                                {
                                    Console.Write("Enter the amount to withdraw: ");
                                    withdrawAmount = double.Parse(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid number");
                                    continue;
                                }

                                if (withdrawAmount > 0 && withdrawAmount <= startBalance)
                                {
                                    startBalance -= withdrawAmount;
                                    Console.Write("Withdrawal successful. New balance: " + startBalance + " OMR");
                                }
                                else if (withdrawAmount <= 0)
                                {
                                    Console.WriteLine("Invalid withdrawal amount. Please enter a positive number");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient funds.");
                                }
                                break;

                            case 3:
                                Console.WriteLine("The current balance is " + startBalance + " OMR");
                                break;

                            case 4:
                                Console.WriteLine("Exiting the ATM...");
                                exitATM = true;
                                break;

                            default:
                                Console.WriteLine("Invalid option. Please choose a valid option from the menu");
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number");
                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("Card blocked");
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        }
    }
}
