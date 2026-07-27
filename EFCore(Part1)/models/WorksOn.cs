using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore_Part1_.models
{
    [PrimaryKey(nameof(EmployeeId), nameof(ProjectId))]
    public class WorksOn
    {
        [ForeignKey("employee")]
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }

        [ForeignKey("project")]
        public int ProjectId { get; set; }
        public Project project { get; set; }

        public int Hours { get; set; }
    }
}
