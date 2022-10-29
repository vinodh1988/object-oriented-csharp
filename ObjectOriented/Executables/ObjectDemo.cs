using ObjectOriented.InheritanceSet;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Executables
{
    internal class ObjectDemo
    {
        static void Main(string[] n) {
            Entity e = new Entity();
            Console.WriteLine(e);
            Console.WriteLine(e.ToString());
            Console.WriteLine(e.GetHashCode());
        }
    }
}
