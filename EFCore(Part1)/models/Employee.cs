using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Part1_.models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int EmployeeSsn { get; set; }
        public string EmployeeFirstName { get; set; }
        public char EmployeeMinit {  get; set; }
        public string EmployeeLastName { get; set; }
        public DateTime Bdate { get; set; }
        public string EmployeeAddress { get; set; }
        public double EmployeeSalary { get; set; }
    }
}
