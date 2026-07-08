namespace PracticeTasks_part5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Fixed Grades Array

            int[] studentGrades = new int[5];

            int i;
            for (i=0; i<5; i++)
            {
                Console.WriteLine("Enter the grade:");
                studentGrades[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("The entered grades are:");
            foreach (int studentGrade in studentGrades)
            {
                Console.WriteLine(studentGrade);
            }

            //////////////////////////////////////////////////////////
            
            //

        }
    }
}
