using System;

namespace ObjectOriented
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p,q; //reference variable

            p=new Person(); //object assigned to reference variable
            q = new Person(1,"Rakesh","Pune");
           // p.sno = 20; //error
            p.Show();
            Console.WriteLine("q print");
            q.Show();
            p.SetValues(1, "Ravi", "Mumbai");
            q.SetValues(2, "Ramesh", "Chennai");
            p.Show();
            Console.WriteLine("q print");
            q.Show();
        }
    }
}

/*
 * A language can be categorized into object oriented programming language
 * if and only if it support 4 features
 * 
 * 1. Encapsulation
 * 2. Abstraction
 * 3. Polymorphism
 * 4. Inherita ce
 * 
 */ 