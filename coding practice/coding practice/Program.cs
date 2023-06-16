using System;
using System.Collections.Generic;
using coding_practice;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the String");
        string sentance = Console.ReadLine();
        Dictionary<string, int> dict = new Dictionary<string, int>();
        WordCount obj = new WordCount();
        dict = obj.WordCountSol(sentance);

        foreach (var d in dict)
        {
            Console.WriteLine(d.Key + " : " + d.Value);
        }


        FizzBuzz obj2 = new FizzBuzz();
        Console.WriteLine("Enter the starting element");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the ending element");
        int end = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the first divisor");
        int divisor1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second divisor");
        int divisor2 = Convert.ToInt32(Console.ReadLine());
        var result = obj2.FizzBuzzSol(start, end, divisor1, divisor2);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }


}