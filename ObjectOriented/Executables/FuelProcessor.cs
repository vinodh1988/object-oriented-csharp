using ObjectOriented.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Executables
{
    internal class FuelProcessor
    {
        static void Main(string[] x) {
            IFuel f=null;
            foreach(string temp in x) {
                switch (temp) {
                    case "stove":
                        f = new Stove();
                        break;
                    case "van":
                        f = new Van();
                        break;
                    case "car":
                        f = new Car();
                        break;
                }
                f.FillFuel();
            }
        }
    }
}
