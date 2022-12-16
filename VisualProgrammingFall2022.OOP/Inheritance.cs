/*
 * Inhertance in C#
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgrammingFall2022.OOP
{
    public class Car
    {
        protected int MyProperty { get; set; }
        private int MyProperty2 { get; set; }
        public string Color { get; set; }
        public string Onwer { get; set; }

        virtual public void ShowCarInfo()
        {
            Console.WriteLine($"Color : {Color}, Owner : {Onwer}");

            MyProperty = 0;
            MyProperty2 = 0;
        }
    }

    public class Alto : Car
    {
        public int[] Ratings { get; set; } = new int[50];
    
        public override void ShowCarInfo()
        {
            Console.WriteLine("Dooms day happen here...");
        }
    }
    public class Yariz : Car
    {
        public void MyMethod()
        {
            MyProperty = 9;
        }
    }


    public static class Inheritance
    {
        public static void Main(string[] args)
        {
            Alto altoCar = new Alto();
            altoCar.Color = "Black";
            altoCar.Onwer = "Yasir";

            Yariz yarizCar = new Yariz();

            yarizCar.Color = "Red";
            yarizCar.Onwer = "Kiren";

            //Car car = altoCar;

            altoCar.ShowCarInfo();

            //car = yarizCar;
            yarizCar.ShowCarInfo();

            Console.ReadKey();
        }
    }
}
