using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static int factorial(int n)
    {
        if (n == 0)
            return 1;
        return n * factorial(n - 1);
    }

    static double combination(int r)
    {
        if (r == 0)
        {
            return 1;
        }
        return (factorial(10) / (factorial(r) * factorial(10 - r)));
    }

    static void Main(String[] args)
    {
        //List<double> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToDouble(arTemp)).ToList();
        double[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), (s) => Convert.ToDouble(s)); 
        double regect = arr[0] / 100;
        double success = 1 - regect;

        var pistons = Convert.ToInt32(arr[1]);
        double answer = 0;
        double answer2 = 0;

        answer2 = combination(2) * Math.Pow(regect, 2) * Math.Pow(success, 10 - 2); // 
        var noRegects = combination(10) * Math.Pow(regect, 0) * Math.Pow(success, 10);
        var oneRegects = combination(9) * Math.Pow(regect, 1) * Math.Pow(success, 9);
        answer2 += noRegects + oneRegects;
        for (int i = 10; i >= 2; i--)
        {
            answer += combination(i) * Math.Pow(regect, i) * Math.Pow(success, 10 - i);
        }
        Console.WriteLine("{0:0.000}", answer2);
        Console.WriteLine("{0:0.000}", answer);
    }
}
