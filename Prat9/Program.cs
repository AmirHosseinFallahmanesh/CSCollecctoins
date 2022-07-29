using System;
using System.Collections.Generic;
using System.Linq;

namespace Prat9
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentRepository repository = new StudentRepository();



            while (true)
            {
                Menu();
                string select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine();
                            Console.WriteLine("Create Page");
                            Console.WriteLine();
                            Console.WriteLine(new string('_', 80));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine("Enter Name");
                            Console.WriteLine();
                            string name = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter Surname");
                            Console.WriteLine();
                            string surname = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter Age ");
                            int age = int.Parse(Console.ReadLine());
                            Student student = new Student()
                            {
                                Age = age,
                                Name = name,
                                Surename = surname
                            };
                            repository.AddStudent(student);
                        }
                        break;
                    case "2":
                        {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Edit Page");
                        Console.WriteLine();
                        Console.WriteLine(new string('_', 80));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("Enter Search");
                        string search = Console.ReadLine();
                         Student student=  repository.FindBySurname(search);
                            if (student!=null)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Enter New Name");
                                Console.WriteLine();
                                string name = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("Enter New Surname");
                                Console.WriteLine();
                                string surname = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine("Enter New Age ");
                                int age = int.Parse(Console.ReadLine());
                                Student updatedStudent = new Student()
                                {
                                    StudentId= student.StudentId,
                                    Age = age,
                                    Name = name,
                                    Surename = surname
                                };
                                repository.UpdateStudent(updatedStudent);
                            }
                            else
                            {
                                Console.WriteLine("Student Not Found");
                                Console.ReadKey();
                            }
                        }
                       
                        break;
                    case "3":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine();
                            Console.WriteLine("Delete Page");
                            Console.WriteLine();
                            Console.WriteLine(new string('_', 80));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine("Enter Search");
                            string search = Console.ReadLine();
                            Student student = repository.FindBySurname(search);
                            if (student != null)
                            {
                               
                                repository.DeleteStudent(student);
                            }
                            else
                            {
                                Console.WriteLine("Student Not Found");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case "4":
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine();
                            Console.WriteLine("Print Page");
                            Console.WriteLine();
                            Console.WriteLine(new string('_', 80));
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            List<Student> students = repository.GetAll();
                            foreach (var item in students)
                            {
                                Console.WriteLine($"name    = {item.Name}");
                                Console.WriteLine($"surname = {item.Surename}");
                                Console.WriteLine($"age     = {item.Age}");
                                Console.WriteLine(new string('*', 40));
                            }
                            Console.ReadKey();
                        }

                        break;
                    case "5":
                       
                        break;
                    case "6":
                        return;

                    default:
                        Console.WriteLine("Try Again");
                        Console.ReadKey();
                        break;
                }
            }


        }

        private static void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("School Demo");
            Console.WriteLine();
            Console.WriteLine(new string('_', 80));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("1)Add student");
            Console.WriteLine();
            Console.WriteLine("2)Edit student");
            Console.WriteLine();
            Console.WriteLine("3)Delete student");
            Console.WriteLine();
            Console.WriteLine("4)Print students");
            Console.WriteLine();
            Console.WriteLine("5)search student");
            Console.WriteLine();
            Console.WriteLine("6)Exit");
            Console.WriteLine();

        }

    

    

   

     

   



#region efDemo
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

        #endregion
    }
}
