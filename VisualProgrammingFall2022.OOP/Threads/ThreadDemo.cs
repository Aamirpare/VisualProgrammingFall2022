using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
/*
 Topic: Threads in C#
    1. Introduction and Concepts
    2. Different ways of creating threads
    3. Delegates and Thread Tasks
    4. Create and Start Threads
    5. Suspend and Resume Threads
    6. Sleeping threads
    7. Background and Foreground Threads
    8. Threads Priortiy and Process Priority
    9. Threads and Process
*/

namespace VisualProgrammingFall2022.OOP.Threads
{
    public class ThreadDemo
    {
        public void Add(int a , int b)
        {

        }
        public static void Task2(object str)
        {
            Console.WriteLine($"Thread {str} starts running...");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Number - {i + 1}");
                //Thread.Sleep(1000);
            }
            Console.WriteLine($"Thread {str} finished...");
        }
        public static void Main(string[] args)
        {
            Task task = Task.Factory.StartNew(() => Console.WriteLine("Task running"));
            //task.Start();
            //ParameterizedThreadStart threadStart = new ParameterizedThreadStart(Task1);
            //Thread thread1 = new Thread(threadStart);
            var thread1 = new Thread(Task2);
            //thread1.IsBackground = true;
            thread1.Priority = ThreadPriority.Lowest;
            thread1.Name = "Thead Huge Task1";
            thread1.Start("Thread One");
            //thread1.Suspend();
            ////thread1.IsBackground = true;
            //Thread thread2 = new Thread(Task2);
            //thread2.Name = "Thread Huge Task2";
            //thread2.Start("Thead Two");
            //Thread.Sleep(200);
            //thread1.Resume();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello");
            //}

            var process = Process.GetCurrentProcess();
            //p.PriorityClass = ProcessPriorityClass.High;
            Console.WriteLine($"Id: {process.Id}, Name: {process.ProcessName}");
            Console.WriteLine();
            Console.WriteLine("Id                Name:");
            
            foreach (var p in Process.GetProcesses())
            {
                Console.WriteLine($"Id: {p.Id}, Name: {p.ProcessName}, Threads: {p.Threads}");
            }

            Console.WriteLine("Main Thread has finished");
        }

    }
}

