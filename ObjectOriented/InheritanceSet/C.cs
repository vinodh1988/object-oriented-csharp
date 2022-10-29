using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.InheritanceSet
{
    internal class C:B
    {
        public void Display()
        {
            Console.WriteLine("C Display");
        }

        public void ShowC()
        {
            Console.WriteLine("ShowC");
        }

      public override void Show()
        {
            Console.WriteLine("Show Method of C");
        }
    }
}
