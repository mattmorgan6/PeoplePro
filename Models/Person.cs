using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeoplePro.Models
{
    public class Person
    {
		//Fields for this class
		public int Id { get; set; }
		public string Name { get; set; }

		//Relationship to Department class
		public int DepartmentId { get; set; }
		public Department Department { get; set; }

		//Relationship to Role class
		public List<PersonRole> PersonRoles { get; set; }
	}
}
