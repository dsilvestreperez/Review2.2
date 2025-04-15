// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Enter the length of the rectangle:");
        double length = Convert.ToDouble(Console.ReadLine());//lenght

        Console.WriteLine("Enter the width of the rectangle:");//width
        double width = Convert.ToDouble(Console.ReadLine());


        double area =  length * width;//area equation

        double perimeter = length + width * 2;//perimeter equation

        Console.WriteLine("Results:");

        Console.WriteLine("Area of the rectangle:" + area);
        Console.WriteLine("Perimeter of the rectangle:" + perimeter);




    }
}