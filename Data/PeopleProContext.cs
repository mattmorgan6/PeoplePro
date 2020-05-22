using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeoplePro.Models;

namespace PeoplePro.Data
{
    public class PeopleProContext : DbContext
    {
        public PeopleProContext (DbContextOptions<PeopleProContext> options)
            : base(options)
        {
        }

        //TODO: Add Models here
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO: Add Tables here
            modelBuilder.Entity<Room>().ToTable("Rooms");

            //TODO: Add relationships here
            //TODO: see https://docs.microsoft.com/en-us/ef/core/modeling/relationships#many-to-many

        }
    }
}
