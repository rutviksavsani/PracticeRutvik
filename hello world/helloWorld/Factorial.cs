using System;
using System.Collections.Generic;
using System.Text;

namespace hello_world.helloWorld
{
    class Factorial
    {

        public int fact(int a)
        {
            if(a==1){
                return 1;
            }
            else
            {
                return fact(a - 1) * a;
            }
        }
    }
}
