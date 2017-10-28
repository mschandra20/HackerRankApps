using System;
using System.Linq;

namespace DiagonalDifference
{

    class Program
    {

        static void Main(String[] args)
        {
            Console.WriteLine("Write the order");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = null;
            int[] DiaAddResult = new int[2];
            Console.WriteLine("enter the matrix");
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                a_temp = Console.ReadLine().Split(' ');

                a[a_i] = a_temp.Select(s => int.Parse(s)).ToArray();//ConvertAll(a_temp, Int32.Parse);
               // Console.WriteLine("Diag 1  --- " + a[a_i][a_i]);
                DiaAddResult[0]+= a[a_i][a_i];
                //Console.WriteLine("Diag 2  ---"+a[a_i][n - a_i - 1]);
                DiaAddResult[1] += a[a_i][n - a_i - 1];
            }
            Console.WriteLine("RESULT IS: ");
            if (DiaAddResult[0] > DiaAddResult[1])
                Console.WriteLine(DiaAddResult[0] - DiaAddResult[1]);
            else
                Console.WriteLine(DiaAddResult[1] - DiaAddResult[0]);

            Console.WriteLine(Math.Abs(DiaAddResult[1] - DiaAddResult[0]));

        }
    }

}
