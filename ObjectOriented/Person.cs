using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented
{
    /*
     * Wrapping up of data and functionalities together under one unit
     * is called Encapsulation
     * 
     * In OOP, a class is a template[model]
     * 
     * to realize the template[model] we need to instantiate it
     * 
     * the syntax to instantiate objects in c# is 
     * 
     *  new Person();
     *  
     *  here Person() is called an constructor
     *  
     *  A constructor is a special method which has same name as that of the class
     *  
     *  it is used to instantiate a class
     *  
     *  each instance occupies a seperate memory space
     *  
     *  In the Person class case,
     *  
     *   sno,name,city are not accessible with instance reference
     *   Show() is accessible
     *   
     *   It is the Class creators responsibility to allow only
     *   the essential features and hide the key background details
     *   and implementations
     *   
     *   we achieve with the help of access modifiers
     *   
     *   Abstraction - allow essential features hide background implementation
     *   
     *   Polymorphism - One name many forms
     *   
     *              1. Method overloading
     *              2. Constructor overloading
     *              3. overriding
     * */
    internal class Person
    {
        private int sno;
        private string name;
        private string city;
        
        public Person() { }
        public Person(int sno, string name, string city) {
            this.sno = sno;
            this.name = name;
            this.city = city;
        }
    public void Show() {
            Console.WriteLine("Sno: {0}", sno);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("City: {0}", city);
        }

        public void SetValues(int sno, string name, string city) {
            this.sno = sno;
            this.name = name;
            this.city = city;
        }

        
    }
}
