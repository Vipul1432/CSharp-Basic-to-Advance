using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudInASP.Models
{
    public class Employee
    {
        
        public int Id { get; set; }
        
        public string Name { get; set; }
        [ForeignKey("Id")]
        public Department Department { get; set; }
    }
}
