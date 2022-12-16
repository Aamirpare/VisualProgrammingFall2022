using StudentPortal.Domain;
using System;

namespace StudentPortal.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
    {
        //Write the eneity framework code,
        public void Add(TEntity entity)
        {
            //using entity framework, ADO.NET, 
            //throw new NotImplementedException();
            Console.WriteLine("Entity added to the database");
        }

        public void Delete(TEntity entity)
        {
            ///throw new NotImplementedException();
            Console.WriteLine("Entity deleted from the database");
        }

        public void Update(TEntity entity)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Entity updated to the database");
        }
    }

    public class FacultyRepository : Repository<Faculty>
    {
        //public void Add(Faculty entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Faculty entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Faculty entity)
        //{
        //    throw new NotImplementedException();
        //}
    }

    public class StudentRepository : Repository<Student>
    {
        //public void Add(Student entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Student entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Student entity)
        //{
        //    throw new NotImplementedException();
        //}
    }

    public class CourseRepository : Repository<Course>
    {

    }

    public class TimeTableRepository : Repository<TimeTable>
    {

    }

}
