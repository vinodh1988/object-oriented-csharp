using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ObjectOriented.Oops
{
    internal class Parent
    {
        protected int a;

        public Parent()
        {
            Console.WriteLine("Parent Default Constructor");
        }

        public Parent(int a)
        {
            Console.WriteLine("Parent parameterized constructor");
            this.a = a;
        }

        public void OnlyForA() {
            Console.WriteLine("only for A");
        }

        public virtual void Show()
        {
            Console.WriteLine("A: " + a);
        }
    }

    internal class Child : Parent
    {

        private int b;

        public Child()
        {
            Console.WriteLine("Child Default Constructor");
        }

        public Child(int b):base(b)
        {
            
            Console.WriteLine("Child parameterized constructor");
            this.b = b;
            
        }
        //method overriding
        public override void Show() {
            base.Show();
            Console.Write("B: " + b);
        }

        public void Display()
        {
            Console.WriteLine("B: " + b);
        }

    }
}
/*
 * if you create object for the child using parameterized/default constructor
 * unless you explicitly call a parent class constructor the defualt
 * constructor of the parent class is always 
 * called
 * 
 * */