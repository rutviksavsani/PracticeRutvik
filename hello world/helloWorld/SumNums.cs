using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace hello_world.helloWorld
{
    class SumNums
    {
        public int sum(List<int> arr)
        {
            if(arr.Count <= 1)
            {
                return arr[0];
            }
            else
            {
                int add = arr[0];
                arr.RemoveAt(0);
                return sum(arr) + add;
            }
        }
    }
}
