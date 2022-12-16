/*
 * Instructor   :   Aamir Shabbir Pare
 * Description  :   Visual Programming Using C#
 * Date         :   23 Sep, 2022
 * Location     :   Room # 105, AB02 Building
 *                  Computer Science Department
 * Topics Covered
 * ==============
 * 1. Working With Solutions and Projects
 *      1. Creating Solution and Projects
 *      2. Adding different types of projects to an existing solution
 *      4. Exploring the projects default storage location
 *      5. Exploring the by default created project files
 * 2. .Net Framework Programs
 *      1. .Net program compilation
 *      2. Execution of a C# program : From C# code to the native code
 *      3. Types of applications 
 * 3. Working with classes
 *      1. Explaining a c# program
 *      2. Difference between a C# and java program
 *      3. Creating classes
 *      4. Access Modifiers in C#
 * 4. Properties and Methods
 *      1. What are properties?
 *      2. Auto-implemented properties
 *      3. Fully implemented properties
 *      4. Creating Methods
*/

using System;

namespace VisualProgrammingFall2022.OOP
{
    public class Student
    {
        float _age; //Backing variable
        public float Age {
            get 
            {
                return _age;
            }
            set 
            {
                if(value > 18)
                {
                    _age = value;
                }
            }
        }
        public int RollNo { get; set; } //Auto Property
        public string Name { get; set; }
        public string Email { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("Roll No: " + RollNo);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Age: " + Age);
        }
    }
    public class Course : Student
    {
        public void ShowCourseInfo()
        {
            Console.WriteLine("Roll No: " + RollNo);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Email: " + Email);
        }
    }

    public class Properties
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.Email = "aamripare@gmail.com";
            student1.Name = "Aamir";
            student1.RollNo = 20;
            
            student1.Age = 19;

            student1.ShowInfo();

            Console.ReadKey();
        }
    }
}
