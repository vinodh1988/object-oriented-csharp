using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Interfaces
{
    internal class Van:IFuel
    {
        public void FillFuel()
        {
            Console.WriteLine("Fuel For Van...");
        }

        public void Show() {
            Console.WriteLine("VAN...");
        }

    }
}
