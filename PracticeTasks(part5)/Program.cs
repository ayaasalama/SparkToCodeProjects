namespace PracticeTasks_part5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Fixed Grades Array

            int[] studentGrades = new int[5];

            int i;
            for (i = 0; i < 5; i++)
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

            // Task 2 - Dynamic To-Do List

            List<string> ToDoList = new List<string>();

            int count;
            for (count = 0; count < 5; count++)
            {
                Console.WriteLine("Enter a Task:");
                ToDoList.Add(Console.ReadLine());

            }

            Console.WriteLine("The To-Do List: ");

            foreach (string item in ToDoList)
            {
                Console.WriteLine("* " + item);
            }

            ///////////////////////////////////////////////////////////

            // Task 3 - Browsing History Stack

            Stack<string> browserHistory = new Stack<string>();
            Console.WriteLine("Enter 3 website URLs:");

            browserHistory.Push(Console.ReadLine());
            browserHistory.Push(Console.ReadLine());
            browserHistory.Push(Console.ReadLine());

            string url = browserHistory.Pop();
            Console.WriteLine("The page currently landed on is " + browserHistory.Peek());

            ////////////////////////////////////////////////////////////////////////////////

            // Task 4 - Customer Service Queue

            Queue<string> Customers = new Queue<string>();
            Console.WriteLine("Enter 3 Customer Names");

            Customers.Enqueue(Console.ReadLine());
            Customers.Enqueue(Console.ReadLine());
            Customers.Enqueue(Console.ReadLine());

            string name = Customers.Dequeue();
            Console.WriteLine("Served Customer: " + name);

            /////////////////////////////////////////////////////////////////////

            // Task 5 - Array Grade Range

            int[] Grades = new int[5];

            int a;
            for (a = 0; a < 5; a++)
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

            // Task 6 - Filtered Shopping List

            List<string> ShoppingList = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter an item to add (or type 'done' to stop): ");
                string item = Console.ReadLine();

                if (item.ToLower() == "done")
                {
                    break;
                }

                ShoppingList.Add(item);
            }

            Console.WriteLine("Shopping List Before Removal");
            foreach (string listItem in ShoppingList)
            {
                Console.WriteLine("- " + listItem);
            }

            Console.WriteLine("Enter the name of the item you want to remove: ");
            string itemToRemove = Console.ReadLine();

            bool wasRemoved = ShoppingList.Remove(itemToRemove);

            if (!wasRemoved)
            {
                Console.WriteLine($"Note: '{itemToRemove}' was not found in the list");
            }

            Console.WriteLine("Final Shopping List After Removal");
            foreach (string listItem in ShoppingList)
            {
                Console.WriteLine("- " + listItem);
            }

            //////////////////////////////////////////////////////////////////////////////////

            // Task 7 - High Score Podium

            List<int> Score = new List<int>();

            Console.WriteLine("Enter 5 game scores:");
            int s;
            for (s = 0; s < 5; s++)
            {
                Console.WriteLine("Enter a score:");
                Score.Add(int.Parse(Console.ReadLine()));
            }

            Score.Sort();
            Score.Reverse();

            Console.WriteLine("1st place: " + Score[0]);
            Console.WriteLine("2nd place: " + Score[1]);
            Console.WriteLine("3rd place: " + Score[2]);

            //////////////////////////////////////////////////////////////////////////

            // Task 8 - Undo Last Action

            Stack<string> actions = new Stack<string>();

            while (true)
            {
                Console.Write("Enter editor action (or type 'stop'): ");
                string action = Console.ReadLine();

                if (action.ToLower() == "stop")
                {
                    break;
                }

                actions.Push(action);
            }

            Console.WriteLine("Undone: " + actions.Pop());
            Console.WriteLine("Undone: " + actions.Pop());

            Console.WriteLine("Remaining Actions");
            foreach (string remainingAction in actions)
            {
                Console.WriteLine("- " + remainingAction);
            }

            //////////////////////////////////////////////////////////////////////////////

            // Task 9 - Grade Analyzer with Functions

            Console.Write("How many grades do you want to enter? ");
            int num = int.Parse(Console.ReadLine());

            List<int> grades = new List<int>();

            for (int x = 0; x < num; x++)
            {
                Console.Write($"Enter grade {x + 1}: ");
                grades.Add(int.Parse(Console.ReadLine()));
            }

            double avg = CalculateAverage(grades);
            Console.WriteLine("Average Grade: " + avg.ToString("F2"));

            int failingGrade = FindFirstFailing(grades);

            if (failingGrade == 0)
            {
                Console.WriteLine("First Failing Grade: No failing grades found!");
            }
            else
            {
                Console.WriteLine("First Failing Grade: " + failingGrade);
            }

            /////////////////////////////////////////////////////////////////////////////////////////

            // Task 10 - Print Queue Manager

            Queue<string> printQueue = new Queue<string>();

            while (true)
            {
                Console.Write("Enter a print job name (or type 'done'): ");
                string job = Console.ReadLine();

                if (job.ToLower() == "done")
                {
                    break;
                }

                printQueue.Enqueue(job);
            }

            Console.WriteLine("Print Queue Before Cancellation:");
            foreach (string job in printQueue)
            {
                Console.WriteLine("- " + job);
            }

            // name of job to cancel
            Console.Write("Enter the name of the job to cancel: ");
            string jobToCancel = Console.ReadLine();

            printQueue = RemoveJob(printQueue, jobToCancel);

            Console.WriteLine("Print Queue After Cancellation:");
            foreach (string job in printQueue)
            {
                Console.WriteLine("- " + job);
            }

        }

        // The task 9 functions
        public static double CalculateAverage(List<int> list)
        {
            if (list.Count == 0)
            {
                return 0;
            }

            int sum = 0;
            foreach (int grade in list)
            {
                sum += grade;
            }
            return (double)sum / list.Count;
        }

        public static int FindFirstFailing(List<int> list)
        {
            return list.Find(x => x < 60);
        }

        ////////////////////////////////////////////////////////////////////////////////////////

        // The task 10 functions

        public static Queue<string> RemoveJob(Queue<string> currentQueue, string cancelName)
        {
            Queue<string> newQueue = new Queue<string>();

            while (currentQueue.Count > 0)
            {
                string currentJob = currentQueue.Dequeue();

                if (currentJob != cancelName)
                {
                    newQueue.Enqueue(currentJob);
                }
            }

            return newQueue;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
    }
}
