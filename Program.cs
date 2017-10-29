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
            int num=3,i,j;
            String[] str = new String[num];
            String temp_str;
            for (i = 0; i < num; i++)
            {
                Console.Write("Please input the ");
                Console.Write(i+1);
                Console.Write("'th name: ");
                str[i] = Console.ReadLine();
                if (str[i][0] < 'A' || str[i][0] > 'Z' && str[i][0] < 'a' || str[i][0] > 'z')
                {
                    Console.WriteLine("Error!");
                    System.Environment.Exit(0);
                }
                str[i] = str[i].Substring(0, 1).ToUpper() + str[i].Substring(1, str[i].Length - 1).ToLower();
                Console.Write(str[i]);
                Console.Write(" is the ");
                Console.Write(i+1);
                Console.WriteLine("'th name");
            }
            for(i=0;i<num-1;i++)
                for(j=i+1;j<num;j++)
                {
                    if(str[i].CompareTo(str[j])>0)
                    {
                        temp_str=str[i];
                        str[i]=str[j];
                        str[j]=temp_str;
                    }
                }
            Console.WriteLine("The names in alphabetical order are: ");
            for(i=0;i<num;i++)
                Console.WriteLine("\"" +str[i] + "\"");
        }
    }
}
