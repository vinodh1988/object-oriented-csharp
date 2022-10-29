using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Interfaces
{
    internal class Stove: IFuel
    {
        public void Burner() {
            Console.WriteLine("Burner burning");
        }

        public void FillFuel()
        {
            Console.WriteLine("Fuel for Stove..");
        }
    }
}
