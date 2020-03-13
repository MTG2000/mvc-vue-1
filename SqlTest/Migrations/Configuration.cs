namespace SqlTest.Migrations
{
    using SqlTest.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SqlTest.DAL.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SqlTest.DAL.SchoolContext context)
        {
            var colleges = new List<College> {
                new College {ID=1, Name="ITE" , YearsOfStudy=5},
                new College {ID=2, Name="Medicine" , YearsOfStudy=6},
                new College {ID=3, Name="Literature" , YearsOfStudy=4}
            };

            colleges.ForEach(s => context.Colleges.AddOrUpdate(s));//Add Or Update is usful when seeding using Migrtions
            context.SaveChanges();

            var students = new List<Student>
            {
            new Student{FirstName="Mohammed",LastName="Ghazal",CollegeID=1},
            new Student{FirstName="Ahmad",LastName="Bazerbashi",CollegeID=2},
            new Student{FirstName="Omar",LastName="Mouraoui",CollegeID=1},
            new Student{FirstName="Alaa",LastName="Hassan",CollegeID=3},
            };

            students.ForEach(s => context.Students.AddOrUpdate(s));
            
            context.SaveChanges();

        }
    }
}
