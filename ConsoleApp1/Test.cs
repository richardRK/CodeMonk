using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class Test
{

    static void Main(String[] args)
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var res = RunningSum1DArray(input);
    }

    private static int[] RunningSum1DArray(int[] input)
    {
        int N = input.Length;
        List<int> lst = new List<int>();
        int calcSum = 0;
        for (int i = 0; i < N; i++)
        {
            if (i == 0)
            {
                lst.Add(input[i]);
            }
            else
            {
                for (int k = i; k >= 0; k--)
                {
                    calcSum += input[k];
                }

                lst.Add(calcSum);
                calcSum = 0;
            }
        }
        return lst.ToArray();
    }
}