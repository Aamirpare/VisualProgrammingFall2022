/*
 * Delegates in C#
*/

using System;

namespace VisualProgrammingFall2022.OOP.DelegatesandEvents.Delegates
{
    public static class SimpleDelegate
    {
        //Declaring a delegate
        public delegate void PrintHanler(string text);
        public static void Main(string[] args)
        {
            //Instantiating a delegate
            PrintHanler handler = new PrintHanler(method);

            //Calling a method using delegate
            handler("Hello delegate experience"); 
            
            //OR
            
            //handler.Invoke("Hello delegate experience");
            
            Console.ReadKey();
        }
        public static void method(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}
