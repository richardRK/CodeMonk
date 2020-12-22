using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int T = Convert.ToInt16(Console.ReadLine());

        while(T-->0)
        {
            string NandK = Console.ReadLine();
            int N = Convert.ToInt32(NandK.Split()[0]);
            int K = Convert.ToInt32(NandK.Split()[1]);
            int[] items = new int[N];
            items = Console.ReadLine().Split().Select(Int32.Parse).ToArray();

            int[] result = shiftRight(items, K);

            Console.WriteLine(string.Join(" ", result));
        }
        Console.ReadLine();
    }

    public static int[] shiftRight(int[] arr, int K)
    {
        int[] demo = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            demo[(i + K) % demo.Length] = arr[i];
        }
        return demo;
    }






}