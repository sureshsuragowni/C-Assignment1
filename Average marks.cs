
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgram
{
    class student
    {
        static void Main(string[] args)
        {


            int studnet1;
            int studnet2;
            int studnet3;
            int studnet4;
            int studnet5;
            int sum;
            int avg;

            System.Console.WriteLine("Enter student 1 marks: ");
            studnet1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter student 2 marks: ");
            studnet2 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter student 3 marks: ");
            studnet3 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter student 4 marks: ");
            studnet4 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter student 5 marks: ");
            studnet5 = Convert.ToInt32(Console.ReadLine());
            sum = studnet1 + studnet2 + studnet3 + studnet4 + studnet5;
            avg = sum / 5;
            Console.WriteLine("The avarage is : " + avg);

            int[] Num = { studnet1, studnet2, studnet3, studnet4, studnet5 };

            Console.WriteLine("your highest marks is : " + Num.Max());
            Console.WriteLine("your Lowest marks is : " + Num.Min());
            Console.ReadLine();

        }
    }
}