using ObjectOriented.InheritanceSet;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Text;

namespace ObjectOriented.Executables
{
    internal class InheritanceSetExectutable
    {
        static void Main(string[] n) {
            B obj = new B();
            obj.Show();
            obj.Display();
            obj.ShowA();
            obj.ShowB();

            Console.WriteLine("#####################");
            A obj1 = obj;

            obj1.Show();
            //obj1.ShowB(); //error
            obj1.Display();
            obj1.ShowA();
            Console.WriteLine("#####################");
            obj1 = new C();
            obj1.Show();// C copy
            obj1.ShowA();
            //obj1.ShowC(); //error
            //obj1.ShowB(); //error
            obj1.Display();//A copy
           
        }
    }
}
