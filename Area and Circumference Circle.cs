﻿using System;
namespace AreaOfCircle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double r, AREA;
            const double PI = 3.14;
           
            Console.WriteLine("Area and circumference of a circle");
            
            Console.Write("\nEnter the radius of circle ");
            r = Convert.ToDouble(Console.ReadLine());
            AREA = PI * r * r;
            Console.WriteLine("\nThe area of circle is {0} when radius is {1}", AREA, r);
            Console.WriteLine("\nThe circumference of circle is {0}", 2 * PI * r);
            
        }
    }
}