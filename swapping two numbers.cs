
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.WriteLine("\n type 1st number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n type 2nd number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("\n After swapping :");
            Console.WriteLine("\n 1st number :");
            Console.WriteLine(number1);
            //Console.ReadLine();
            Console.WriteLine("\n 2nd number :");
            Console.WriteLine(number2);
            //Console.ReadLine();
        }
    }
}
