using ObjectOriented.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Executables
{
    internal class ShapeProcessor
    {
        static void Main(string[] n) {
            Shape s=null;
            // = new Shape();
            //for Shape reference is possible but not object
            Console.WriteLine("a. Rectangle b. Square (rect/square) ? ");
            string choice = Console.ReadLine();

            switch (choice) {
                case "rect":
                    s = new Rectangle(5,4);
                    break;
                case "square":
                    s = new Square(4);
                    break;
            }

            s.Show(); //subclass willbe called because ovveriden
            s.Area();
            s.Perimeter();

        }
    }
}
