using System;
using System.Collections.Generic;
using System.Collections;

/*
  Topic : C# Collections
    1. Non-Generic Collections
    2. Generic Collections
 */

/*
    Shopping Cart Application Using Generic Collection List<T>
    This lab task must demostrate skills
       - Inheritance
       - Polymorphism
       - Code Resue

    A company wants to lauch a e-commencer system that can facilitate users
    to select product and collect them in the shopping cart.

    Company x
    E-Commerce Application x
    Users x
    Product =>  Array , ArrayList, HasTable, Dictiona
    Cart =>
*/



namespace VisualProgrammingFall2022.OOP.Collections
{
    public class CollectionBasics
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 20, 10, 40, 90, 88}; //Basic dotnet primitives
            string name = "";
            
            ArrayList arrList = new ArrayList();
            arrList.Add(10);
            arrList.Add("Aamir");
            arrList.Add(90.45);

            string key = "Alorithm";

            string clsName = "Entrypoint";
            var obj = new CollectionBasics();

            var colls = new CollectionBasics[]
            {
                new CollectionBasics(),
                new CollectionBasics()
            };

            Hashtable ht = new Hashtable();
            ht.Add(key, 90);
            ht.Add(clsName, obj);

   


            //var xy = (string)arrList[0];
            //Console.WriteLine(xy);

            int index = 0;
            foreach (var item in arrList)
            {
                Console.WriteLine(arrList[index++]);
            }



            //Dictionary

            Dictionary<int, string> Students = new Dictionary<int, string>()
            {
                { 100, "Kulsum"},
                { 101, "Anil"},
                { 201, "Alishba"}
            };

            Students.Add(1, "Aamir");
            Students.Add(2, "Karishma");
            Students.Add(3, "John");
            Students.Add(4, "Ghost");
           
            foreach (var student in Students)
            {
                if (Students.ContainsKey(201))
                {
                    Console.WriteLine("Alishba is out....");
                }
               
                Console.WriteLine($"Key: {student.Key}, Value: {student.Value}");

                
            }
           

            Console.WriteLine("Dictionary Traversed");
           
            Console.ReadKey();

            //With .NETFramework Libaray - System.Collections.Generic
            List<int> listNumbers = new List<int>() { 300, 800, 901 };
            //listNumbers.Add()"aamir");
            listNumbers.Add(10);
            listNumbers.Add(20);
            listNumbers.Add(40);
            listNumbers.Add(60);
            listNumbers.Add(90);
            listNumbers.Add(140);

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += 10;
                Console.WriteLine("Number:" + numbers[i]);
            }

            //Traversing generic List
            foreach (var item in listNumbers)
            {
                Console.WriteLine($"List Number : {item}");
            }

            listNumbers.Add(902);
            listNumbers.Add(901);
            listNumbers.Add(900);

            var e = listNumbers[0];

            listNumbers.Remove(e);

            listNumbers.ForEach(x => Console.WriteLine($"N : {x}"));

            Console.ReadKey();
        }

    }
}
