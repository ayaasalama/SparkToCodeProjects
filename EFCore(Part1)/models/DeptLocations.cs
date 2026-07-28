using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore_Part1_.models
{
    [PrimaryKey(nameof(DepartmentID), nameof(DepartmentLocation))]
    public class DeptLocations
    {
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public Department Department { get; set; }


        public string DepartmentLocation { get; set; }
    }
}
