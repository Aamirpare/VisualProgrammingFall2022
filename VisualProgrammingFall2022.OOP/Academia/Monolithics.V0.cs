using System;

namespace VisualProgrammingFall2022.Generics.Academia.V0
{
    /*
      Monolithics Code V0
      ====================
      Tightly Coupled Architecture, the domain object is an aggregate 
      that couples the code of multiple layers together and makes things 
      worst.
    */

    ////////////////////Domain Layer//////////////////////////////
    public class Student
    {
        DbStudentAccess _DbContext { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Student()
        {
            _DbContext = new DbStudentAccess();
        }
        public void Add()
        {
            //Dbconnection
            var student = new Student();
            student.Name = this.Name;
            student.Email = this.Email;
            student.Id = this.Id;

            //Save student to the database.
            _DbContext.Add(student);

        }
        public void Delete()
        {
            _DbContext.Delete(this);
        }

        public void Update()
        {
            _DbContext.Update(this);
        }
    }
    public class Faculty
    {
        DbFacultyAccess _DbContext { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public void Add()
        {
            //Dbconnection
            var faculty = new Faculty();
            faculty.Name = this.Name;
            faculty.Email = this.Email;
            faculty.Id = this.Id;

            //Save student to the database.
            _DbContext.Add(faculty);

        }
        public void Delete()
        {
            _DbContext.Delete(this);
        }

        public void Update()
        {
            _DbContext.Update(this);
        }
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

    //////////////////////DB Acess Layer/////////////////////////
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
                Id = 100,
                Name = "Aamir Khan",
                Email = "aamir.khan@gmail.com"
            };

            //Added to dtabase
            student.Add();
            faculty.Add();
            
            Console.ReadKey();
        }
    }
}
