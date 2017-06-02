
/*

Write a method complements(array, number) which returns true if any two numbers in the array sum to the number.

*/

using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static bool complements(int[] a, int b)
    {
        var pos = 0;
        var rv = false;
        foreach (var parent in a)
        {
            pos++;
            foreach (var other in a.Skip(pos))
            {
                var sum = parent + other;
                if (sum == b)
                {
                    rv = true;
                    break;   
                }
            }
        }
        return rv;
    }

    public static bool complement_rec(int[] a, int b)
    {
        if (a.Length <= 1)
        {
            return false;
        }
        else
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (a[0] + a[i] == b)
                {
                    return true;
                }
            }
            return complement_rec(a.Skip(1).ToArray(), b);
        }
    }

    public static void Main()
    {
        int[] odds = { 1, 3, 5, 7, 9, 11 };
        int[] ints = { -11, 40, 17, -5, -1, -11, 2, 9 };

        Console.WriteLine(complement_rec(odds, 4) == true);
        Console.WriteLine(complement_rec(odds, 1) == false);
        Console.WriteLine(complement_rec(ints, -22) == true);
        Console.WriteLine(complement_rec(ints, 16) == true);
        Console.WriteLine(complement_rec(ints, 40) == false);

    }

}

