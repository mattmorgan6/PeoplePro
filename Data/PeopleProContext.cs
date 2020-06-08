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
        public PeopleProContext(DbContextOptions<PeopleProContext> options)
            : base(options)
        {
        }

        //TODO: Add Models here
        public DbSet<Department> Departments { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO: Add Tables here
            modelBuilder.Entity<Room>().ToTable("Rooms");

            //TODO: Add relationships here
            //TODO: see https://docs.microsoft.com/en-us/ef/core/modeling/relationships#many-to-many
            modelBuilder.Entity<PersonRole>()
            .HasKey(r => new { r.PersonId, r.RoleId });

            modelBuilder.Entity<PersonRole>()
                .HasOne(pr => pr.Person)
                .WithMany(p => p.PersonRoles)
                .HasForeignKey(pr => pr.PersonId);

            modelBuilder.Entity<PersonRole>()
                .HasOne(pr => pr.Role)
                .WithMany(r => r.PersonRoles)
                .HasForeignKey(pr => pr.RoleId);
        }
    }
}
