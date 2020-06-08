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

            // Un-comment this if you don't want to duplicate seed the DB
            // Look for any rooms.
            //if (context.Rooms.Any())
            //{
            //    return;   // DB has already been seeded
            //}

            var rooms = new Room[]
            {
                new Room { RoomName="LINC" },
                new Room { RoomName="MU" },
                new Room { RoomName="Weatherford" },
                new Room { RoomName="Austin Hall" }
            };
            context.Rooms.AddRange(rooms);
            context.SaveChanges();


            //TODO: Seed the database with the other model data
        }
    }
}
