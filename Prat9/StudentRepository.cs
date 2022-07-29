using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prat9
{
   public class StudentRepository
    {
        private DemoContext context;
        public StudentRepository()
        {
            context = new DemoContext();
        }

        public void AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        public List<Student> GetAll()
        {
            return context.Students.ToList();
        }

        public void UpdateStudent(Student updatedStudent)
        {
           Student student= context.Students.Find(updatedStudent.StudentId);
            student.Name = updatedStudent.Name;
            student.Surename = updatedStudent.Surename;
            student.Age = updatedStudent.Age;
            context.SaveChanges();
        }

        public void DeleteStudent(Student student)
        {
            context.Students.Remove(student);
            context.SaveChanges();
        }

        public Student FindBySurname(string surname)
        {
            return context.Students.SingleOrDefault(a => a.Surename == surname);
        }


    }
}
