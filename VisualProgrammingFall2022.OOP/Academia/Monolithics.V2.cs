using System;

namespace VisualProgrammingFall2022.Generics.Academia.V2
{
    /*
      Monolithics Code.V2
      ===================
      * In this version we introduced generics to make further enhancements to the architecture.
      * By using generics we are now able to reuse the data access for all domain objects
      * using one dbcontext.
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
    //Introducing Generics 
    public class DBContext<TEntity>
    {
        //TEntity is avaiable in whole class 
        public TEntity Entity { get; set; }
        public void Add(TEntity entiry)
        {
            Console.WriteLine("Data Saved to the database.");
        }
        public void Delete(TEntity faculty)
        {
            Console.WriteLine("Entity object deleted from the database");
        }
        public void Update(TEntity faculty)
        {
            Console.WriteLine("Entity object updated to the database");
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

            //Saving student object to the database
            DBContext<Student> dbContext = new DBContext<Student>();
            dbContext.Add(student);

            //Saving faculty object to the database
            DBContext<Faculty> dbContext2 = new DBContext<Faculty>();
            dbContext2.Add(faculty);

            Console.ReadKey();
        }
    }
}
