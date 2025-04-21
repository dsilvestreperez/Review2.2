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
            double length = Convert.ToDouble(Console.ReadLine());//lenght

            Console.WriteLine("Enter the width of the rectangle:");//width
            double width = Convert.ToDouble(Console.ReadLine());


            double area = length * width;//area equation

            double perimeter = length + width * 2;//perimeter equation

            Console.WriteLine("Results:");

            Console.WriteLine("Area of the rectangle:" + area);// output of area
            Console.WriteLine("Perimeter of the rectangle:" + perimeter);//output of perimeter

        }

    }

}
