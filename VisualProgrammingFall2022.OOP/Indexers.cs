using System;
using System.Collections.Generic;
/*
    C# Properties and Indexers 
*/


namespace VisualProgrammingFall2022.OOP
{
    public class Country
    {
        private List<string> Names = new List<string>();
        //{
        //    "Pakistan", "Afghanistan", "Iran", "India"
        //};

        public void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        public Country()
        {
            Names.Add("Pakistan");
            Names.Add("Afghanistan");
            Names.Add("Iran");
            Names.Add("India");
        }
        public int Size => Names.Count;

        //Indexer
        public object this[string index]
        {
            get { return ""; /* return the specified index here */ }
            set { /* set the specified index to value here */ }
        }

        /* 
         * SYNTAX
         * access_modifier return_Type this[index_parameter]
        */
        public string this[int index]
        {
            get 
            { 
                if( index >= 0 && index < Size)
                {
                    return Names[index];
                }
               return ""; 
            }
            set { if (index >= 0 && index < Size) Names[index] = value; }
        }
        public int Count { get; set; }

    }
    public static class Indexers
    {
        public static void Main(string[] args)
        {
            Country countries = new Country();

            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine(countries[i]);
            }

            Console.ReadKey();
        }
    }
}
