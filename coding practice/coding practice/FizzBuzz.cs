using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class FizzBuzz
    {
       public ArrayList FizzBuzzSol(int start,int end,int divisor1,int divisor2)
        {
            ArrayList list= new ArrayList();
            for(int i=start;i<=end;i++)
            {
                if(i%divisor1==0 && i%divisor2==0)
                {
                    list.Add("FizzBuzz");
                }
                else if(i%divisor1==0)
                {
                    list.Add("Fizz");
                }
                else if (i % divisor2 == 0)
                {
                    list.Add("Buzz");
                }
                else
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
