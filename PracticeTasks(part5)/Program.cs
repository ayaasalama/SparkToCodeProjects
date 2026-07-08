namespace PracticeTasks_part5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Fixed Grades Array

            //int[] studentGrades = new int[5];

            //int i;
            //for (i=0; i<5; i++)
            //{
            //    Console.WriteLine("Enter the grade:");
            //    studentGrades[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("The entered grades are:");
            //foreach (int studentGrade in studentGrades)
            //{
            //    Console.WriteLine(studentGrade);
            //}

            //////////////////////////////////////////////////////////

            // Task 2 - Dynamic To-Do List

            //List<string> ToDoList = new List<string>();

            //int count;
            //for (count=0; count<5; count++)
            //{
            //    Console.WriteLine("Enter a Task:");
            //    ToDoList.Add(Console.ReadLine());

            //}

            //Console.WriteLine("The To-Do List: ");

            //foreach(string item in ToDoList)
            //{
            //    Console.WriteLine("* " + item);
            //}

            ///////////////////////////////////////////////////////////

            // Task 3 - Browsing History Stack

            //Stack<string> browserHistory = new Stack<string>();
            //Console.WriteLine("Enter 3 website URLs:");

            //browserHistory.Push(Console.ReadLine());
            //browserHistory.Push(Console.ReadLine());
            //browserHistory.Push(Console.ReadLine());

            //string url = browserHistory.Pop();
            //Console.WriteLine("The page currently landed on is " + browserHistory.Peek());

            ////////////////////////////////////////////////////////////////////////////////

            // Task 4 - Customer Service Queue

            //Queue<string> Customers = new Queue<string>();
            //Console.WriteLine("Enter 3 Customer Names");

            //Customers.Enqueue(Console.ReadLine());
            //Customers.Enqueue(Console.ReadLine());
            //Customers.Enqueue(Console.ReadLine());

            //string name = Customers.Dequeue();
            //Console.WriteLine("Served Customer: " + name);

            /////////////////////////////////////////////////////////////////////

            // Task 5 - Array Grade Range

            int[] Grades = new int[5];

            int a;
            for (a=0; a<5; a++)
            {
                Console.WriteLine("Enter a grade:");
                Grades[a] = int.Parse(Console.ReadLine());
            }

            Array.Sort(Grades);

            int sum = 0;
            for (int b = 0; b < 5; b++)
            {
                sum += Grades[b];
            }
            double average = sum / 5.0;

            Console.WriteLine("Lowest Grade: " + Grades[0]);
            Console.WriteLine("Highest Grade: " + Grades[4]);
            Console.WriteLine("Average Grade: " + average);

            ////////////////////////////////////////////////////

            



        }
    }
}
