using PeoplePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeoplePro.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PeopleProContext context)
        {
            context.Database.EnsureCreated();

            //Look for any rooms.
            if (context.Roles.Any())
            {
                return;   // DB has already been seeded
            }

            var rooms = new Room[]
            {
                new Room { Name="LINC" },
                new Room { Name="MU" },
                new Room { Name="Weatherford" },
                new Room { Name="Austin Hall" }
            };
            context.Rooms.AddRange(rooms);
            context.SaveChanges();


            var departments = new Department[]
            {
                new Department { Name="Engineering", RoomId=1 },
                new Department { Name="Education", RoomId=3 },
                new Department { Name="Philosophy", RoomId=2 },
                new Department { Name="Math", RoomId=1 }
            };
            context.Departments.AddRange(departments);
            context.SaveChanges();

            var people = new Person[]
            {
                new Person { Name="Stephen King", DepartmentId=2 },
                new Person { Name="Tom Brady", DepartmentId=3 },
                new Person { Name="Tiger Woods", DepartmentId=4 },
                new Person { Name="Bob Marley", DepartmentId=4 }
            };
            context.People.AddRange(people);
            context.SaveChanges();

            var roles = new Role[]
            {
                new Role { Name="Professor", },
                new Role { Name="Instructor" },
                new Role { Name="President", },
                new Role { Name="Student" }
            };
            context.Roles.AddRange(roles);
            context.SaveChanges();


        }
    }
}
