using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Part1_.models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ProjectNumber { get; set; }
        public string ProjectLocation { get; set; }
    }
}
