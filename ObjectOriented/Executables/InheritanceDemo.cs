using ObjectOriented.Oops;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Executables
{
    internal class InheritanceDemo
    {
        static void Main(string[] s) {
            /* Child c = new Child(3);
             c.Display();
             c.Show();*/

         /*   Parent p = new Parent();
            //  p.Display();//No visibility
            //Parent will not know anything about child*/

            Parent a = new Child();
            a.OnlyForA();
            a.Show();
            //a.Display();//error -not visible to reference of type parent
        } 
    }
}
/*
 * 
 *According to oop language principle
 *if  a parent class reference is pointing to child object
 *it using the reference we call a overriden method always
 *the child copy will be called
 */