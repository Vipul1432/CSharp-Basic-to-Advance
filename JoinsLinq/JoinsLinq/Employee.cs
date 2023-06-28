using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinsLinq
{
    internal class Employee
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public DateOnly? DOB { get; set; }

        public int? DeptId { get; set;}
    }
}
