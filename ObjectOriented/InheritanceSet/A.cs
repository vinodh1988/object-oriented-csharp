using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.InheritanceSet
{
    internal class A
    {
        public void Display() {
            Console.WriteLine("A Display");
        }

        public void ShowA() {
            Console.WriteLine("ShowA");
        }

        public virtual void Show() { 
            Console.WriteLine("Show Method of A");
        }
    }
}
