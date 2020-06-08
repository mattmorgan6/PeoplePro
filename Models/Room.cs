using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PeoplePro.Models
{
    public class Room
    {
        public int RoomId { get; set; }

        [Required]
        [Display(Name = "Room Name")]
        [StringLength(50)]
        public string RoomName { get; set; }

        // TODO: Add Department models https://docs.microsoft.com/en-us/ef/core/modeling/relationships#many-to-many
        public ICollection<Department> Departments { get; set; }
    }
}
