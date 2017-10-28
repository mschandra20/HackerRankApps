using System;
using System.Linq;

namespace PlusMinus
{
    class Program
    {
        static void Main(String[] args)
        {
           // Double posRes, NegRes, ZeroRes;
            int pos=0, neg=0, zero=0;
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = arr_temp.Select(s=>int.Parse(s)).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) pos++;
                else if (arr[i] < 0) neg++;
                else zero++;
            }
            Console.WriteLine( (pos/ (float)n).ToString("0.000000") 
                    + " \n"  + (neg/ (float)n).ToString("0.000000") 
                    + " \n" + (zero/(float)n).ToString("0.000000"));

        }
    }
}
