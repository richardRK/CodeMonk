using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        long T = Convert.ToInt64(Console.ReadLine());
        long i, j;
        long count = 0;
        string[] arr = null;

        while (T-- > 0)
        {
            long N = Convert.ToInt64(Console.ReadLine());

            long[,] arr1 = new long[N, N];

            for (i = 0; i < N; i++)
            {
                arr = (Console.ReadLine().Split(' '));

                for (j = 0; j < N; j++)
                {
                    arr1[i, j] = long.Parse(arr[j]);

                }
            }

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    for (long x = i; x < N; ++x)
                    {
                        for (long y = j; y < N; ++y)
                        {
                            if (arr1[x, y] < arr1[i, j])

                                count++;
                        }

                    }
                }
            }
            Console.WriteLine(count);
        }


        Console.ReadLine();
    }








}