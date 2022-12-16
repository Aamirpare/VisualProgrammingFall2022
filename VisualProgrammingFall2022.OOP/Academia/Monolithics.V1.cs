using System;

namespace VisualProgrammingFall2022.Generics.Academia.V1
{
    /*
      Monolithics Code.V1
      ===================
      * In this version we will try to make enhancements to the architecture
        by decoupling the DBAcess layer from the domain entities.
    */

    ////////////////////Domain Layer//////////////////////////////
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
    }

    //////////////////////DB Acess Layer/////////////////////////
    public class DbStudentAccess
    {
        public void Add(Student student)
        {
            Console.WriteLine("Student added to the database");
        }
        public void Update(Student student)
        {
            Console.WriteLine("Student updated to the database");
        }
        public void Delete(Student student)
        {
            Console.WriteLine("Student deleted from the database");
        }
    }
    public class DbFacultyAccess
    {
        public void Add(Faculty faculty)
        {
            Console.WriteLine("Faculty added to the database");
        }
        public void Update(Faculty faculty)
        {
            Console.WriteLine("Faculty updated to the database");
        }
        public void Delete(Faculty faculty)
        {
            Console.WriteLine("Faculty deleted from the database");
        }
    }

    //////////////////////UI Layer Code//////////////////////////
    public static class Monolithics
    {
        public static void Main(string[] args)
        {
            //Getting input from the UI
            var student = new Student()
            { 
                Id = 90, 
                Name = "Sara Khan",
                Email = "sara.gamil.com"
            };
            var faculty = new Faculty() 
            { 
                Id=100, 
                Name="Aamir Khan", 
                Email="aamir.khan@gmail.com" 
            };

            var dbFacultyContext = new DbFacultyAccess();
            var dbStudentContext = new DbStudentAccess();

            dbFacultyContext.Add(faculty);

            dbStudentContext.Add(student);

            Console.ReadKey();
        }
    }
}
