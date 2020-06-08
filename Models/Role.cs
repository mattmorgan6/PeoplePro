using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PeoplePro.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        [Required]
        [Display(Name = "Role Name")]
        [StringLength(50)]
        public string RoleName { get; set; }

        public IList<PersonRole> PersonRoles { get; set; }
    }
}
