using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore_Part1_.models
{
    [PrimaryKey(nameof(EmployeeSsn), nameof(ProjectNumber), nameof(ProjectName))]
    public class WorksOn
    {
        [ForeignKey("employee")]
        public int EmployeeSsn { get; set; }
        public Employee employee { get; set; }

   
        public int ProjectNumber { get; set; }
        public string ProjectName { get; set; }

        [ForeignKey("ProjectNumber, ProjectName")]
        public Project project { get; set; }

        public int Hours { get; set; }
    }
}
