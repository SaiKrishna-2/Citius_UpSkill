using System;
using System.Collections.Generic;
using coding_practice;

class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Enter the String");
        //string sentance=Console.ReadLine();
        //Dictionary<string, int> dict = new Dictionary<string, int>();
        //codingChallange1 obj=new codingChallange1();
        //dict=obj.WordCount(sentance);

        //foreach(var d in dict)
        //{
        //    Console.WriteLine(d.Key+" : "+d.Value);
        //}

        //------------------------------------------------------------------------------
        codingChallange2 obj2 = new codingChallange2();
        Console.WriteLine("Enter the starting element");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the ending element");
        int end = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the first divisor");
        int divisor1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second divisor");
        int divisor2 = Convert.ToInt32(Console.ReadLine());
        var result = obj2.FizzBuzz(start, end, divisor1, divisor2);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }


}
class codingChallange1
{
    public  Dictionary<string, int> WordCount(string sentance)
    {
        sentance = sentance.ToLower();
        string[] words = sentance.Split(' ');
        Dictionary<string, int> dict = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            if (dict.ContainsKey(words[i]))
            {
                dict[words[i]]++;
            }
            else
            {
                dict.Add(words[i], 1);
            }
        }
        return dict;
    }
}
