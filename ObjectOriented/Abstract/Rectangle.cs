using System;

namespace ObjectOriented.Abstract
{
    internal class Rectangle : Shape
    {
        private int length;
        private int breadth;

        public Rectangle( int length, int breadth) : base(4, "Rectangle")
        
            {
                this.length = length;
                this.breadth = breadth;
            }

        public override void Area()
        {
            Console.WriteLine("Area is {0}", length * breadth);
        }

        public override void Perimeter()
        {
            Console.WriteLine("Perimeter is {0}", 2 * (length + breadth)); 
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Breadth: {0}", breadth);
        }
    }
}
