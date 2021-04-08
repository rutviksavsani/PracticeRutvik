using System;
using System.Collections.Generic;
using System.Linq;
namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {

            #region part1
            //Console.WriteLine("===========================================================================");
            //Console.WriteLine("Print Hello World");
            //#region task1 Print Hello World
            //helloWorld.helloWorld task1 = new helloWorld.helloWorld();
            //task1.print();
            //Console.WriteLine("===========================================================================");



            #region Min of two Numbers

            //Console.WriteLine("Minimum of two Numbers");
            //helloWorld.MinNum min_num = new helloWorld.MinNum();
            //Console.WriteLine("Enter the First Number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Second Number : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The Minimum of two Numbers is :"+ min_num.FindMin(a, b));
            //Console.WriteLine("===========================================================================");

            #endregion

            #region Max of two Numbers using ternary

            //Console.WriteLine("Maximum of two Numbers");

            //helloWorld.MaxTernery max_num = new helloWorld.MaxTernery();
            //Console.WriteLine("Enter the First Number : ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Second Number : ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The Maximum of two Numbers is :" + max_num.maximum(a, b));
            //Console.WriteLine("===========================================================================");

            #endregion

            #region swap their values without using the third variable

            //Console.WriteLine("Swap two Numbers");

            //helloWorld.swap swap = new helloWorld.swap();
            //Console.WriteLine("Enter the First Number : ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Second Number : ");
            //b = Convert.ToInt32(Console.ReadLine());
            //swap.swapNum(a,b);

            //Console.WriteLine("===========================================================================");



            #endregion

            #region Print Maximum from an array

            //Console.WriteLine("Print Maximum from an array");
            //helloWorld.MaxArray max = new helloWorld.MaxArray();
            //Console.WriteLine("Enter Array of Size 5 : ");
            //int[] arr = new int[5];
            //for(int i = 0; i < 5; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("The Max Of two numbers is "+max.MaxArr(arr)); 

            //Console.WriteLine("===========================================================================");


            //Console.ReadLine();
            #endregion

            #endregion

            #region part 2

            #region W.A.P. which accepts a string as an input parameter and reverses it. 
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Enter String to Reverse :");

            helloWorld.StringReverse strrev = new helloWorld.StringReverse();
            Console.WriteLine( strrev.reverse(Console.ReadLine()));
            Console.WriteLine("===========================================================================");


            #endregion

            #region W.A.P. to read 10 numbers from the keyboard and find their sum and average.
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Enter 10 number to find Sum :");
            List<int> li = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                li.Add(Convert.ToInt32( Console.ReadLine()));
            }

            helloWorld.SumNums sums = new helloWorld.SumNums();
            Console.WriteLine(sums.sum(li));
            Console.WriteLine("===========================================================================");


            #endregion

            #region W.A.P. to find maximum and minimum elements in an array. 
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Enter 5 number to find max and min :");
            li = new List<int>();
            for(int i = 0; i < 5; i++)
            {
                li.Add(Convert.ToInt32( Console.ReadLine()));
            }
            int max = li.Max();
            int min = li.Min();
            Console.WriteLine("Max is "+ max);
            Console.WriteLine("Min is " + min);
            Console.WriteLine("===========================================================================");



            #endregion

            #region W.A.P.to count a total number of duplicate elements in an array. 
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Enter 5 number to find no if duplicates :");
            li = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                li.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for (int i = 0; i < li.Count; i++)
            {
                int count = 0;
                int val = li[i];
                for (int j = i; j < li.Count; j++)
                {
                    if (val == li[j] && val != -1)
                    {
                        li[j] = -1;
                        count++;
                    }
                }
                if(val!= -1)
                {
                    Console.WriteLine("The occurence of {0} is {1} times", val, count);
                }
                
            }



            
            Console.WriteLine("===========================================================================");


            #endregion

            #region W.A.P to create a recursive function to find the factorial of a given number. 
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Enter no to find factorial :");
           // Console.WriteLine(strrev.reverse(Console.ReadLine()));
            helloWorld.Factorial fa = new helloWorld.Factorial();
            Console.WriteLine("The Factorial is {0}",fa.fact(Convert.ToInt32(Console.ReadLine())));
            
            Console.WriteLine("===========================================================================");



            #endregion
            Console.ReadLine();

            #endregion

        }
    }
}
