using System;
using System.Linq;

namespace BirthdayCandles
{
    class Program
    {
        static int BirthdayCakeCandles(int n, int[] ar)
        {
            int count = 0, max = ar.Max();
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] ==max ) count++;
            }
            return count;
            
            
            // Complete this function
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = ar_temp.Select(s => int.Parse(s)).ToArray();
            int result = BirthdayCakeCandles(n, ar);
            Console.WriteLine(result);
        }
    }
}
