using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Part1_.models
{
    public class Dependent
    {
        public int DependentId { get; set; }
        public string DependentName { get; set; }
        public char DependentSex { get; set; }
        public DateTime DependentBdate { get; set; }
        public string DependentRelationship { get; set; }
    }
}
