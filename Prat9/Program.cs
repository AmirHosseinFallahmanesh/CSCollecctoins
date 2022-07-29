using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Prat9
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoContext context = new DemoContext();
            // context.Database.EnsureCreated();

            //CreateDemo(context);
            //FechData(context);
            //updateDemo(context);
            //DeleteDemo(context);

            Console.ReadKey();
        }

        private static void DeleteDemo(DemoContext context)
        {
            Student student = context.Students.Find(3);
            context.Students.Remove(student);
            context.SaveChanges();
        }

        private static void updateDemo(DemoContext context)
        {
            Student student = context.Students.Find(3);
            student.Age = 20;

            context.SaveChanges();

            Console.WriteLine("Done");
        }

        private static void FechData(DemoContext context)
        {
            var result = context.Students.Where(a => a.Age > 5).ToList();
            var result1 = context.Students.ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void CreateDemo(DemoContext context)
        {
            Student student = new Student()
            {
                Age = 14,
                Name = "reza",
                Surename = "rezaii"
            };
            context.Students.Add(student);
            context.SaveChanges();
        }
    }

    public class DemoContext:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           string connectionString="Server=.;Database=CSDEMO;Trusted_Connection=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Student> Students { get; set; }
    }

   public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public int Age { get; set; }
    }
}
