using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using EJournal.Models;

namespace EJournal.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            IdentityRole seeding;
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Teacher",
                    NormalizedName = "TEACHER"
                },
                new IdentityRole
                {
                    Name = "Student",
                    NormalizedName = "STUDENT"
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}

