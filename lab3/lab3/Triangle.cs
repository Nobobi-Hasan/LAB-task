using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class Triangle
    {
        int x;
        int y;
        int z;

        public int X
        {
            set { x = value; }
            get { return x; }
        }

        public int Y
        {
            set { y = value; }
            get { return y; }
        }

        public int Z
        {
            set { z = value; }
            get { return z; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
            Console.WriteLine("Z: " + z);
        }

        public void TestTriangle()
        {
            if(x==y && y==z)
                Console.WriteLine(" The triangle is equilateral.");

            else if(x == y || y == z)
                Console.WriteLine("The triangle is isosceles");

            else
                Console.WriteLine(" The triangle is scalene");
        }

    }
}
