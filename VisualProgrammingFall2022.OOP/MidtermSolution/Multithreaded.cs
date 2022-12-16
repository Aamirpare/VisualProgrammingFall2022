/*
 * Author       : Aamir Pare
 * Description  : Midterm Examination VP Fall 2022.
 * Date         : 19th November, 2022
 * Location     : Home G-11/4, Islamabad
*/

using System;
using System.Collections.Generic;
using System.Threading;
/*
 03 	Write a multi-threaded program that launches two similar 
        tasks of your choice at runs them simultaneously?					(10 Marks)
*/
namespace VisualProgrammingFall2022.OOP.MidtermSolution
{
    public class Multithreaded
    {
        List<string> Courses = new List<string>()
        {
            "Visual Programming", "System Programming", 
            "Web Engineering", "Maths", "Data Science"
        };
        public void Task1()
        {
            Console.WriteLine("Task one start");
            foreach (var course in Courses)
            {
                Console.WriteLine(course);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Task one end");
        }
        public void Task2()
        {
            Console.WriteLine("Task two start");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Count - {i + 1}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Task two end");
        }
        public static void Main(string[] args)
        {
            var tasks = new Multithreaded();
            
            //Create thread one
            var thread1 = new Thread(tasks.Task1);
            thread1.Start();
            
            //Create thread two
            var thread2 = new Thread(tasks.Task2);
            thread2.Start();

            Console.ReadKey();
        }
    }
}
