using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore_Part1_.models
{
    [PrimaryKey(nameof(ProjectNumber), nameof(ProjectLocation))]
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ProjectNumber { get; set; }
        public string ProjectLocation { get; set; }

        // WorksOn
        public List<WorksOn> WorksOn { get; set; }

        // Controlled by
        [ForeignKey("Department")]
        public int DepartmentNumber { get; set; }
        public Department Department { get; set; }

    }
}
