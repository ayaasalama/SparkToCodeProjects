using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore_Part1_.models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Key]
        public int EmployeeSsn { get; set; }
        public string EmployeeFirstName { get; set; }
        public char EmployeeMinit {  get; set; }
        public string EmployeeLastName { get; set; }
        public DateTime Bdate { get; set; }
        public string EmployeeAddress { get; set; }
        public double EmployeeSalary { get; set; }

        // Supervision (Self-Relation (1-M))
        [InverseProperty("supervisor")]
        public List<Employee> supervisee { get; set; }


        [ForeignKey("supervisor")]
        public int SupervisorID { get; set; }
        public Employee supervisor { get; set; }


        // Dependent (1-1)
        public Dependent Dependent { get; set; }

        // Worksfor (1-M)
        [ForeignKey("Dept")]
        public int DepartmentID { get; set; }
        public Department Dept { get; set; }

        // Manage
        [InverseProperty("Employee")]
        public Department ManagedDepart { get; set; }

        // Works_on
        public List<WorksOn> worksOn { get; set; }
    }
}
