using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinsLinq
{
    internal class Leave
    {
        public int ID { get; set; }

        public int? EmpId { get; set; }

        public DateOnly Date { get; set; }

        public string? Reason { get; set; }

        public string? Title { get; set; }
    }
}
