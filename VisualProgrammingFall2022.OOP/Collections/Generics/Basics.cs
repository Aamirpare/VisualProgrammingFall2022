using System;
using System.Collections.Generic;

namespace VisualProgrammingFall2022.OOP.Collections.Generics
{
    public class DBContext<TEntiry>
    {
        //TEntity is avaiable in whole class 
        public TEntiry Entity { get; set; }
        public void Add(TEntiry entiry)
        {
            Console.WriteLine("Data Saved to the database.");
        }
    }
    public class Basics
    {
        static void Display(object param) 
        {
            Console.WriteLine(param);    
        }

        //static void Display(string param)
        //{
        //    Console.WriteLine(param);
        //}

        //static void Display(float param)
        //{
        //    Console.WriteLine(param);
        //}

        public static void Display<T>(T param)
        {
            Console.WriteLine($"Generics : {param}");
        }
        public static void Main(string[] args)
        {

            DBContext<Student> dbContext = new DBContext<Student>();

            //DBContext<string> anotherConext = new DBContext<string>();

            Display(10);
            Display("ksdjfdsaj");
            Display(5.99f);

            Display<int>(10);
            Display<string>("Hello");
            Display<decimal>(599.9m);

            Console.ReadKey();
        }

    }
}
