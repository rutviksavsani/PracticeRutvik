using System;
using System.Collections.Generic;
using System.Text;

namespace hello_world.helloWorld
{
    class swap
    {
        public void swapNum (int a,int b )
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("The Swapped values are ");
            Console.WriteLine("A = "+a);
            Console.WriteLine("B = " + b);
        }
    }
}
