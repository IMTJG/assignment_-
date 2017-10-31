//***********************************************************
// Name: Tian Jing
// Title: Assignment1.cs
// Time spent: so much time
// Date: 10/26/2017
//************************************************************** 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, Feet, Inches,BMI;
            Console.WriteLine("What is your weight?");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your height? ");
            Console.WriteLine("Feet:");
            Feet = double.Parse(Console.ReadLine());
            Console.WriteLine("Inches:");
            Inches = double.Parse(Console.ReadLine());
            Inches = Inches + 12 * Feet;
            BMI = (weight * 703) / (Inches * Inches);
            Console.WriteLine(BMI.ToString("0.00"));
        }
    }
}
