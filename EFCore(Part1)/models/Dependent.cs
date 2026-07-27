using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore_Part1_.models
{
    [PrimaryKey(nameof(EmployeeId), nameof(DependentName))]
    public class Dependent
    {
        public int DependentId { get; set; }
        public string DependentName { get; set; }
        public char DependentSex { get; set; }
        public DateTime DependentBdate { get; set; }
        public string DependentRelationship { get; set; }

        // 
        [ForeignKey("employee")]
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }
    }
}
