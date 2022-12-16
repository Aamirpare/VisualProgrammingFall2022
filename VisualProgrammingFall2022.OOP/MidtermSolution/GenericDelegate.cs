/*
 * Author       : Aamir Pare
 * Description  : Midterm Examination VP Fall 2022.
 * Date         : 19th November, 2022
 * Location     : Home G-11/4, Islamabad
*/
using System;

namespace VisualProgrammingFall2022.OOP.MidtermSolution
{
    /*
        02 	Create a generic delegate that can be used for basic arithmetic operations, 
            like addition, subtraction, multiplication and division?	(5 Marks)
    */
    public delegate decimal ArithmeticDelegate<T>(T left, T right);

    public class Arithmetics
    {
        public static void Main(string[] args)
        {
            //instantiate delegate
            ArithmeticDelegate<decimal> arithmetics = null;
            
            //Addition
            arithmetics = (x, y) => x + y;
            var result = arithmetics.Invoke(100.55m, 10);
            Console.WriteLine($"{100.55} + {10} = {result}");

            //subtraction 
            arithmetics = (x, y) => x - y;
            result = arithmetics.Invoke(100.99m, 10);
            Console.WriteLine($"{100.99} - {10} = {result}");

            //multipliction 
            arithmetics = (x, y) => x * y;
            result = arithmetics.Invoke(100, 10);
            Console.WriteLine($"{100} x {10} = {result}");

            //division 
            arithmetics = (x, y) => x / y;
            result = arithmetics.Invoke(100, 10);
            Console.WriteLine($"{100} / {10} = {result}");

            Console.ReadKey();
        }
    }
}
