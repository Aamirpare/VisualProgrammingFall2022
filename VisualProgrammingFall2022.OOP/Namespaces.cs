/*
 * Namespaces in C#
 * Describe: =>     Namespace is a logical separation of closely reated collection of classes.
 *           =>     Namespace help to resolve the naming conflicts between classes, i.e two class
 *                  within a same namespces is a conflict, the namespaces resolve such problems.
 *           =>     See this coding example below to understand the concept. 
*/  

using System;
using EN = UnitubeCore.Entities;
using UE = UnitubeCore.Extensions;

namespace VisualProgrammingFall2022.OOP
{
    public static class NameSpaces
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NAMESPACES IN CSHARP");
            Console.WriteLine("=====================" + Environment.NewLine);
            var message = $"Organizing a coding event, you are coordially invited.";
            EN::Faculty eFaculty = new EN::Faculty();
            eFaculty.SendEmail(message);
            UE::Faculty exFaculty = new UE::Faculty();
            exFaculty.SendEmail(message);
            Console.ReadKey();
        }
    }
}

namespace UnitubeCore.Extensions
{
    public class Faculty
    {
        public void SendEmail(string message) => Console.WriteLine($"Extensions Namespace Faculty : {message}");
    }
}
namespace UnitubeCore.Entities
{
    public class Faculty
    {
        public void SendEmail(string message) => Console.WriteLine($"Entites Namespace Faculty : {message}");
    }
}
