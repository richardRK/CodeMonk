using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class Test
{
    //public static int K;

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

    private static int[][] HighFive(int[][] items)
    {
        int K = 5;

        items = items.OrderByDescending(y => y[1]).ToArray();

        int N = items.Length;
        List<int[]> solution = new List<int[]>();
        int i = 0;
        while (i < N)
        {
            int id = items[i][0];
            int sum = 0;

            // obtain total using the top 5 scores
            for (int k = i; k < i + K; ++k)
                sum += items[k][1];
            // ignore all the other scores for the same id
            while (i < N && items[i][0] == id)
                i++;
            solution.Add(new int[] { id, sum / K });
        }
        return solution.ToArray();
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