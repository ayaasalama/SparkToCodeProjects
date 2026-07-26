using EFCore_Part1_.models;

namespace EFCore_Part1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProjectContext context = new ProjectContext();

            //// add data case 1 
            //Employee e1 = new Employee(); 
            //e1.EmployeeFirstName = "Aya";
            //e1.EmployeeMinit = 'A';
            //e1.EmployeeLastName = "Salama";
            //e1.Bdate = new DateTime(2004, 5, 29);
            //e1.EmployeeSalary = 280;
            //e1.EmployeeAddress = "Muscat";
            
            ////forgot to add Ssn so will update it later 
            //context.employees.Add(e1);
            //context.SaveChanges();

            //Case 2: register employee with user input
            Console.WriteLine("Register employee");

            Employee e2 = new Employee();

            Console.Write("Enter your Firstname: ");
            e2.EmployeeFirstName = Console.ReadLine();

            Console.Write("Enter your Middle init: ");
            e2.EmployeeMinit = char.Parse(Console.ReadLine());

            Console.Write("Enter your Lastname: ");
            e2.EmployeeLastName = Console.ReadLine();

            Console.Write("Enter your salary: ");
            e2.EmployeeSalary = double.Parse(Console.ReadLine());

            Console.Write("Enter your Address: ");
            e2.EmployeeAddress = Console.ReadLine();

            Console.Write("Enter your Ssn: ");
            e2.EmployeeSsn = int.Parse(Console.ReadLine());

            context.employees.Add(e2);
            context.SaveChanges();
        }
    }
}
