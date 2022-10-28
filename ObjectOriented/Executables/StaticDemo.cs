using ObjectOriented.Oops;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObjectOriented.Executables
{
    internal class StaticDemo
    {
        public static void ShowLine()
        {
            Console.WriteLine("----------------------------------------------");
        }
        static void Main(string[] n)
        {
            InstanceVsClass x = new InstanceVsClass("one");
            InstanceVsClass y = new InstanceVsClass("two");
            InstanceVsClass z = new InstanceVsClass("three");

            x.Show();
            ShowLine();
            y.Show();
            ShowLine();
            z.Show();
            ShowLine();

            InstanceVsClass.Print();
           // x.Print();
        }
    }
}


/*
 *   player{
 *      name -instance
 *      runs - instance
 *      balls -instance
 *      totalscore- static
 *   }
 *   factorial()?
 *   college
 *   student{
 *     htno  -instance
 *     name -instance
 *     branch -instance
 *     collegename -static
 *   }
 *   
 *   
 *   Student(
 * static
 *     percentile(); //formula to calculate percentils is one and the same for all
 * non static -instance    
 *     marklist(); //each student marklist is different associated with individual scores
 *   )
 * */