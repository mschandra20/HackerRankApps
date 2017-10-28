using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> Sum = new List<long>();
            long temp=0;
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = arr_temp.Select(s => int.Parse(s)).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                temp = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    
                    if (j != i)
                    temp += arr[j];
                }
                Sum.Add(temp);
            }
            Console.WriteLine(Sum.Min()+" "+Sum.Max());

            
        }
    }
}
