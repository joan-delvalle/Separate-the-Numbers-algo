using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'separateNumbers' function below.
     *
     * The function accepts STRING s as parameter.
     */

    public static void separateNumbers(string s)
    {
        int n = s.Length;

    for (int length = 1; length <= n / 2; length++)
    {
        string first = s.Substring(0, length);
        long num = long.Parse(first);
        string sequence = first;
        long next = num + 1;

        while (sequence.Length < n)
        {
            sequence += next.ToString();
            next++;
        }

        if (sequence == s)
        {
            Console.WriteLine("YES " + first);
            return;
        }
    }

    Console.WriteLine("NO");


    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            Result.separateNumbers(s);
        }
    }
}
