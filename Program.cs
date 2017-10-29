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
            String str1, str2, str3,str;
            Console.Write("Please input the first name: ");
            str1=Console.ReadLine();
            if (str1[0] < 'A' || str1[0] > 'Z' && str1[0] < 'a' || str1[0] > 'z')
            {
                Console.WriteLine("The first name : Error!");
                System.Environment.Exit(0);
            }
            Console.Write("Please input the second name: ");
            str2=Console.ReadLine();
            if (str2[0] < 'A' || str2[0] > 'Z' && str2[0] < 'a' || str2[0] > 'z')
            {
                Console.WriteLine("The second name : Error!");
                System.Environment.Exit(0);
            }
            Console.Write("Please input the third name: ");
            str3 = Console.ReadLine();
            if (str3[0] < 'A' || str3[0] > 'Z' && str3[0] < 'a' || str3[0] > 'z')
            {
                Console.WriteLine("The third name : Error!");
                System.Environment.Exit(0);
            }
            if (str1.CompareTo(str2) > 0)
            {
                str = str1;
                str1 = str2;
                str2 = str;
            }
            if (str1.CompareTo(str3) > 0)
            {
                str = str1;
                str1 = str3;
                str3 = str;
            }
            if (str2.CompareTo(str3) > 0)
            {
                str = str2;
                str2 = str3;
                str3 = str;
            }
            Console.WriteLine("The names in alphabetical order are: ");
            Console.WriteLine("\""+str1.Substring(0,1).ToUpper()+str1.Substring(1,str1.Length-1).ToLower()+"\"");
            Console.WriteLine("\""+str2.Substring(0,1).ToUpper()+str2.Substring(1,str2.Length-1).ToLower()+"\"");
            Console.WriteLine("\""+str3.Substring(0,1).ToUpper()+str3.Substring(1,str3.Length-1).ToLower()+"\"");
        }
    }
}
