using StudentPortal.Domain;
using System;

namespace StudentPortal.Repository
{
    public static class RepositoryDemo
    {
        public static void Main(string[] args)
        {
            IRepository<Faculty> repository = new FacultyRepository();
            repository.Add(new Faculty());
            repository.Update(new Faculty());
            repository.Delete(new Faculty());

            Console.ReadKey();
        }

    }
}
