using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PeoplePro.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required]
        [Display(Name = "Department Name")]
        [StringLength(50)]
        public string DepartmentName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Budget { get; set; }

        public Room Room { get; set; }
        public ICollection<Person> People { get; set; }
    }
}
