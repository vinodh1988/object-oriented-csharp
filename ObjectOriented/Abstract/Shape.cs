using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Abstract
{
    internal abstract class Shape
    {
        protected int nos;
        protected String name;

        public Shape(int nos, string name)
        {
            this.nos = nos;
            this.name = name;
        }
        public  virtual void Show() {
            Console.WriteLine("Number of sides: " + nos);
            Console.WriteLine("Name: "+name);
        }

        public abstract void Area();
        public abstract void Perimeter();
    }

    

    /*
     *  abstract class is a class that cannot have
     *  objects
     *  
     *  there is no rule that an abstract class
     *  must contain abstract methods
     *  
     *  if a class contains abstract methods
     *  class must also be abstract
     */
}
