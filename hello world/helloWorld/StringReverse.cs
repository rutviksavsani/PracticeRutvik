using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace hello_world.helloWorld
{
    public class StringReverse
    {
         public String reverse(String str)
        {
            if(str.Length <= 1)
            {
                return str;
            }
            else
            {
                return reverse(str.Substring(1)) + str[0];
            }
        }
    }
}
