using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Print Hello World");
            #region task1 Print Hello World
            helloWorld.helloWorld task1 = new helloWorld.helloWorld();
            task1.print();
            Console.WriteLine("===========================================================================");

            #endregion

            #region Min of two Numbers
           
            Console.WriteLine("Minimum of two Numbers");
            helloWorld.MinNum min_num = new helloWorld.MinNum();
            Console.WriteLine("Enter the First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Minimum of two Numbers is :"+ min_num.FindMin(a, b));
            Console.WriteLine("===========================================================================");

            #endregion

            #region Max of two Numbers using ternary
           
            Console.WriteLine("Maximum of two Numbers");

            helloWorld.MaxTernery max_num = new helloWorld.MaxTernery();
            Console.WriteLine("Enter the First Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Maximum of two Numbers is :" + max_num.maximum(a, b));
            Console.WriteLine("===========================================================================");

            #endregion

            #region swap their values without using the third variable

            Console.WriteLine("Swap two Numbers");

            helloWorld.swap swap = new helloWorld.swap();
            Console.WriteLine("Enter the First Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number : ");
            b = Convert.ToInt32(Console.ReadLine());
            swap.swapNum(a,b);
            
            Console.WriteLine("===========================================================================");


       
            #endregion

            #region Print Maximum from an array

            Console.WriteLine("Print Maximum from an array");
            helloWorld.MaxArray max = new helloWorld.MaxArray();
            Console.WriteLine("Enter Array of Size 5 : ");
            int[] arr = new int[5];
            for(int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Max Of two numbers is "+max.MaxArr(arr)); 

            Console.WriteLine("===========================================================================");


            Console.ReadLine();
            #endregion




            //Console.Write("Enter Number 1");
            //String a = Console.ReadLine();
            //Console.WriteLine("Enter Number 2");
            //String b = Console.ReadLine();

            //Console.WriteLine(a + b);
        }
    }
}
