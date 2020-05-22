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

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().ToTable("Rooms");
            modelBuilder.Entity<Department>().ToTable("Departments");
            modelBuilder.Entity<Person>().ToTable("Persons");

            //Add the one room to many posts relationship to the database
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Room)
                .WithMany(r => r.Departments);

            //Add the one department to many people relationship to the database
            modelBuilder.Entity<Person>()
                .HasOne(p => p.Department)
                .WithMany(d => d.People);
        }
    }
}
