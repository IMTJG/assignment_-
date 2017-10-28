//question 1~3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String myString = "Coding is fun!";
            int n = myString.Length,i,count=0,d_num=0;
            for (i = 0; i < n; i++)
            {
                if (myString[i] >= 'A' && myString[i] <= 'Z' || myString[i] >= 'a' && myString[i] <= 'z')
                    count++;
                if (myString[i] == 'd') d_num++;
            }
            Console.WriteLine(count);
            Console.Write("The number of 'd' is: ");
            Console.WriteLine(d_num);
            String subString = myString.Substring(10, 3);
            Console.WriteLine(subString);
        }
    }
}

//****************************************************************************************************************
//question 5
//Hy
