using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore_Part1_.models
{
    [PrimaryKey(nameof(EmployeeSsn), nameof(ProjectNumber))]
    public class WorksOn
    {
        [ForeignKey("employee")]
        public int EmployeeSsn { get; set; }
        public Employee employee { get; set; }

        [ForeignKey("project")]
        public int ProjectNumber { get; set; }
        public Project project { get; set; }

        public int Hours { get; set; }
    }
}
