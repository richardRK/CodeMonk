using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class Test
{

    static void Main(String[] args)
    {
        //var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //var res = RunningSum1DArray(input);


        int[][] studentIDS = new int[][] {
                new int[] { 1, 91 },
                new int[] { 1, 92 },
                new int[] { 1, 60 },
                new int[] { 1, 65 },
                new int[] { 1, 87 },
                new int[] { 1, 100 },
                new int[] { 2, 93 },
                new int[] { 2, 97 },
                new int[] { 2, 77 },
                new int[] { 2, 100 },
                new int[] { 2, 76 }
            };


        HighFive(studentIDS);
    }

    private static void HighFive(int[][] items)
    {
        Sort(items, 1);
    }
    private static void Sort<T>(T[][] data, int col)
    {
        Comparer<T> comparer = Comparer<T>.Default;
        Array.Sort<T[]>(data, (x, y) => comparer.Compare(x[col], y[col]));
    }


    private static int[] RunningSum1DArray(int[] input)
    {
        int N = input.Length;
        List<int> lst = new List<int>();
         int calcSum = 0;
        for (int i = 0; i < N; i++)
        {
                for (int k = i; k >= 0; k--)
                {
                    calcSum += input[k];
                }
                lst.Add(calcSum);
                calcSum = 0;
        }
        return lst.ToArray();
    }
}