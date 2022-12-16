/*
    Delegates in C#
    Describe : =>   A delegate in c# is a programming way to create 
                    a type that can hold a reference to a method.
               =>   In C&C++ a function pointer is a simillar concept of delegates in c#.
               =>   In javascript callback functions is also a simillar concept of delegates in c#,
                    and in c# behind the callback functions are the delegtes.
               =>   There is heavy use of delegate in .Net because .Net event pattern is 
                    based on delegates.
               =>   Delegates enble multicasting, the concept simillar as broadcasting. 
                    A delegates can hold references to more than one method and execute them all by a 
                    single invoke.
              =>    MessageDelegate messageDelegate = new MessageDelegate(PrintMessage); can be simplified
                    as MessageDelegate messageDelegate = PrintMessage; both statements are same but the earlier
                    is an old way of C#.
*/

using System;
namespace VisualProgrammingFall2022.OOP
{
    public delegate void MessageDelegate(string message);
    public class DelegatesDemo
    {
        public static void PrintMessage(string msg)
        {
            Console.WriteLine($"Message from PrintMessage method: {msg}");
        }

        public static void SendEmail(string content)
        {
            Console.WriteLine($"Message from SendEmail method: {content}");
        }
        public static void Main(string[] args)
        {

            MessageDelegate messageDelegate; //Creates a delegate type "MessageDelegate"

            //Creating new object like below is an old ways of c#, in a new way we can simple assign a method.
            messageDelegate = new MessageDelegate(PrintMessage); //First reference to a method.

            messageDelegate += new MessageDelegate(SendEmail); //Using += another referece to a differ

            Console.WriteLine("\nIt will be printed two times...");
            messageDelegate("Email message to be sent"); 

            //Without using new keyword simply assing a method to the delegate.
            messageDelegate += PrintMessage; //Using += another reference to a PrintMessage method

            Console.WriteLine("\nIt will be printed three times...");
            messageDelegate.Invoke("Once again print message"); //Invokes all mehtods 

            Console.ReadKey();
        }
    }
}
