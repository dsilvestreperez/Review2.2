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

           Console.WriteLine("Enter the length of the rectangle:");//entering the length of the two side of the rectangle
            double length = Convert.ToDouble(Console.ReadLine());//input of the lenght for both side of the rectangle

            Console.WriteLine("Enter the width of the rectangle:");//entering the width of the two side
                double width = Convert.ToDouble(Console.ReadLine());//input of the width of the two side of the rectangle 


                double area = length * width;//equation for the basic area

            double perimeter = length + width * 2;//the equation for the basic perimeter

            Console.WriteLine("Results:");

            Console.WriteLine("Area of the rectangle:" + area);//display the total area of the rectangle
            Console.WriteLine("Perimeter of the rectangle:" + perimeter);//display the total perimeter of the rectangle

        }

    }

}
