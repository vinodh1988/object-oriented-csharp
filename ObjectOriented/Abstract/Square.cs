using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Abstract
{
    internal class Square: Shape
    {

        private int side;
            public Square(int side) : base(4, "Square")

            {
            this.side = side;
                
            }

            public override void Area()
            {
                Console.WriteLine("Area is {0}", side * side);
            }

            public override void Perimeter()
            {
                Console.WriteLine("Perimeter is {0}", 4 * side);
            }

            public override void Show()
            {
                base.Show();
                Console.WriteLine("Side: {0}", side);
               
            }
        }
    }



