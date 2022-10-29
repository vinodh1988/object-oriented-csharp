using ObjectOriented.InheritanceSet;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Executables
{
    internal class Casting
    {
        static void Main(string[] n) {
            A obj = new B();
            A obj1 = new A();
            A obj2 = new C();
            B b1 = (B)obj; //convertible
                           //B b2 = (B)obj1; //not convertible -exception
            B b2 = new C();
            C c  = (C)obj2; //convertible
            C c2 = (C)b2; //convertible
            //C c1 = (C)b1; // not convertible
          
        
        }
    }
}


/*
 *   Subclass reference cannot hold super type 
 *   
 *   but we cannot attempt to do typecasting
 * 
 * 
 */