using ObjectOriented.Oops;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Executables
{
    internal class InheritanceDemo
    {
        static void Main(string[] s) {
            Child c = new Child(3);
            c.Display();
            c.Show();
        } 
    }
}
