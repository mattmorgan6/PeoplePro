using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeoplePro.Models
{
    public class Department
    {
		//Fields for this class
		public int Id { get; set; }
		public string Name { get; set; }

		//Relationship with the Room Class
		public int RoomId { get; set; }
		public Room Room { get; set; }

		//Relationship with the Person Class
		public List<Person> People { get; set; }
	}
}
