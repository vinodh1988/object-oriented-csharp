using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Interfaces
{
    internal class Car: IFuel
    {
        public void FillFuel()
        {
            Console.WriteLine("Car Fuel");
        }

        public void Show() {
            Console.WriteLine("CAR ...");
        }
    }
}
