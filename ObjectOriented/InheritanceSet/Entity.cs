using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.InheritanceSet
{
    internal class Entity
    {
        public override string ToString()
        {
            return "Hello World @ " + base.ToString();
        }
    }
}
