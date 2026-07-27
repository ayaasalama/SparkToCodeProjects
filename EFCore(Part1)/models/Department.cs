using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore_Part1_.models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public int DepartmentNumber { get; set; }
        public string DepartmentName { get; set; }
        public DateTime MsgStartDate  { get; set; }

        // Worksfor
        [InverseProperty("Dept")]
        public List<Employee> Employees { get; set; }

        // Manage
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime ManageStartDate { get; set; }

    }
}
