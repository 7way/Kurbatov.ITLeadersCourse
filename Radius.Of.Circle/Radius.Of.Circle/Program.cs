using System;
using static Radius.Of.Circle.IO.Output;
using static Radius.Of.Circle.IO.Input;

namespace Radius.Of.Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Out.WriteLine("Calculate circle perimeter and area.");
            Out.WriteLine();

            double radius = default;
            double circleArea = 0.0;
            double circlePerimeter = 0.0;

            Out.Write("Input circle radius: ");
            radius = double.Parse(In.ReadLine());

            circleArea = Math.PI * Math.Pow(radius, 2);
            circlePerimeter = 2 * Math.PI * radius;

            Out.WriteLine("Circle area is: " + circleArea);
            Out.WriteLine("Circle perimeter is: " + circlePerimeter);
        }
    }
}
