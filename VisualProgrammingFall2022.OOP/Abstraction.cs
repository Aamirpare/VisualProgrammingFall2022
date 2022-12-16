using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    1. Abstract classes and Interfaces
    2. Virtual functions and abstract functions
    3. Base class method hiding
    4. Sealed classes
*/

namespace VisualProgrammingFall2022.OOP
{

    interface IEmployee
    {
        void SendEmail();
        void ShowInfo();
    }

    public abstract class BaseEmployee : IEmployee
    {
        public string FullName { get; set; } = "Name";
        public string Email { get; set; } = "abc@yahoo.com";
        public double Salary { get; set; } = 4500.0;
        public void SendEmail()
        {

        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Full Name : {FullName}, Email : {Email}, Salary : {Salary}");
        }
    }

    public class VisitingEmployee : BaseEmployee
    {
        //public override void ShowInfo()
        //{
        //    Console.WriteLine("Abstract base class version");
        //}
    }

    public sealed class HourlyEmployee : VisitingEmployee
    {
        //public override void ShowInfo()
        //{
        //    Console.WriteLine("Hourly class version ");
        //}
    }

    //public class MyEmployee : HourlyEmployee
    //{

    //}
    public class Startup
    {
        public static void Mainxxx(string[] args)
        {
            IEmployee iEmployee; //reference
            BaseEmployee baseEmployee; //reference
            iEmployee = new VisitingEmployee(); // concreate object
            iEmployee.ShowInfo();
            
            iEmployee = new HourlyEmployee()
            {
                Email = "Aamir@yahoo.com",
                FullName = "Aamir Pare",
                Salary = 98000.89
            };

            iEmployee.ShowInfo();

            Console.ReadKey();
        }
    }

}
