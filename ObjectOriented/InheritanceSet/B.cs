using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.InheritanceSet
{
    internal class B:A
    {
        public void Display()
        {
            Console.WriteLine("B Display");
        }

        public void ShowB()
        {
            Console.WriteLine("ShowB");
        }

        public override void Show()
        {
            Console.WriteLine("Show Method of B");
        }
    }
}
