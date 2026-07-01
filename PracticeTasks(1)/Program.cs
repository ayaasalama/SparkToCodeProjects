namespace PracticeTasks_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Personal Info Card

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height in meters");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Are you a student? (True/False)");
            bool isStudent = bool.Parse(Console.ReadLine());

            Console.WriteLine("Name: " + name + ", Age: " + age + ", Height: " + height + ", Student: " + isStudent);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            //
        }
    }
}
