namespace CsharpSession2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //For loop:

            int counter = 0;

            for (counter = 10; counter >= 5; counter--)
            {
                Console.WriteLine("certain message loop number:" + counter);

            }

            ///////////////////////////////////////////////////////////////////

            //While loop:

            bool exitDecision = false;
            string userInput;

            while (exitDecision == false)
            {
                Console.WriteLine("print menu");

                Console.WriteLine("Do you want to exit? (y/n)");
                userInput = Console.ReadLine();
                
                if (userInput == "y")
                {
                    exitDecision = true;
                }
            }

            /////////////////////////////////////////////////////////////////////////


            //Do while loop:

            bool exit = false;
            string Input;
            int userchoice;

            do
            {
                try
                {

                    Console.WriteLine("Do you want to exit? (1/2)");
                    userchoice = int.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.WriteLine("print menu");


                Console.WriteLine("Do you want to exit? (y/n)");
                Input = Console.ReadLine();

                if (Input == "y")
                {
                    exit = true;
                }

            } while (exit == false);


        }
    }
}
