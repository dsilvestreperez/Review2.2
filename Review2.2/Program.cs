using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consoledocumation
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("Enter the length of the rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());//string variable for the input of length

            Console.WriteLine("Enter the width of the rectangle:");//string variable  for the input of witdh
                double width = Convert.ToDouble(Console.ReadLine());


                double area = length * width;

            double perimeter = length + width * 2;

            Console.WriteLine("Results:");

            Console.WriteLine("Area of the rectangle:" + area);//Print the value of the area
            Console.WriteLine("Perimeter of the rectangle:" + perimeter);//Print the value of the perimeter

        }

    }

}
