using System;
using System.Collections.Generic;
using System.Text;
/*
 * Within a class there are two kinds of members
 * 1. instance member
 * 2. class member
 * 
 * instance member - a copy of the member is available with every object separatly
 * class member - only one copy of the member will be available for all the objects
 */
namespace ObjectOriented.Oops
{
    internal class InstanceVsClass
    {
        private string name;
        private int instance; //instance member
        private static int total; // class member
        //constructor is also an instance method
        public InstanceVsClass(string name) {
            this.name = name;
            instance++;
            total++;
        }
        //instance member
        public void Show() {
            Console.WriteLine("instance: {0}", instance);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Total: {0}", total);
        }

        public static void Print() {
            
           // Console.WriteLine("instance: {0}", instance);
           // Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Total: {0}", total);

        }

        // in a static context instance members are not accessible
        //in an instance method, static members can be accessedd
    }
}
