using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class Test
{

    static void Main(String[] args)
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int N = Convert.ToInt32(Console.ReadLine());
        TwoSum(input, N);
    }

    public static int[] TwoSum(int[] nums, int target)
    {




    }

    private static string leftRotateShift(string B, int shift)
    {
        shift %= B.Length;
        return B.Substring(shift) + B.Substring(0, shift);
    }

    private static string rightRotateShift(string B, int shift)
    {
        shift %= B.Length;
        return B.Substring(B.Length - shift) + B.Substring(0, B.Length - shift);
    }



}