using System;
using System.Data.Entity;
using StudentSystem.Data.Migrations;

using StudentSystem.Data;
using StudentSystem.Models;

namespace StudentSystem.ConsoleClient
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Creating database...");
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());

            Random randomGen = new Random();

            using (var dbContext = new StudentSystemDbContext())
            {
                for (int i = 1; i <= 20; i++)
                {
                    Student student1 = new Student()
                    {
                        Name = "Ivan" + i,
                        Number = i
                    };

                    dbContext.Students.Add(student1);
                }

                dbContext.SaveChanges();
            }
        }
    }
}
