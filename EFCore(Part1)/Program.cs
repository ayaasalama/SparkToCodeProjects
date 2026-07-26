using EFCore_Part1_.models;

namespace EFCore_Part1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProjectContext context = new ProjectContext();

            // add data case 1 
            Employee e1 = new Employee();
            e1.EmployeeFirstName = "Aya";
            e1.EmployeeMinit = 'A';
            e1.EmployeeLastName = "Salama";
            e1.Bdate = new DateTime(2004, 5, 29);
            e1.EmployeeSalary = 280;
            e1.EmployeeAddress = "Muscat";

            context.employees.Add(e1);
            context.SaveChanges();
        }
    }
}
