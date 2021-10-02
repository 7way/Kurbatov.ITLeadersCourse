﻿using System;
using static ConsoleApp.CSharpBasic.IO.Output

namespace ConsoleApp.CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            int intVar = 1;
            int intVar2 = 2;

            Out.WriteLine(intVar2);
            Out.Write(intVar);

            intVar = intVar2 = 3;

            Out.WriteLine(intVar);
            Out.WriteLine(intVar2);

            //double doubleVar1, doubleVar2 = 2.3;

            //Out.WriteLine(doubleVar1);
            //Out.WriteLine(doubleVar2);

            Out.WriteLine(double.MinValue);
            Out.WriteLine(decimal.MaxValue);

            int x, y, result;
            x = 100;
            y = 200;

            result = x + y / 100;
            result = (x + y) / 100;

            x = 5;
            y = 4;

            Out.WriteLine(x + y);
            Out.WriteLine(x * y);
            Out.WriteLine(x - y);
            Out.WriteLine(x + (y++));
            Out.WriteLine(x + (++y));
            Out.WriteLine(x + (y--));
            Out.WriteLine(x + (--y));
            Out.WriteLine(14 / x);
            Out.WriteLine(14 % x);

            bool a = true;
            bool b = false;

            Out.WriteLine(a);
            Out.WriteLine(a || b);
            Out.WriteLine(a && b);
            Out.WriteLine((1 < 2) || (1 > 2));
            Out.WriteLine((1 < 2) && (1 > 2));

            // Concatenation
            string firstName = "John";
            string lastName = "Smith";

            Out.WriteLine(firstName + 1 + 2); // John12
            Out.WriteLine(firstName + (1 + 2)); // John3

            // Comparison operators
            x = 10;
            y = 5;

            Out.WriteLine("x > y : " + (x > y));    // True 
            Out.WriteLine("x < y : " + (x < y));    // False 
            Out.WriteLine("x >= y : " + (x >= y));  // True 
            Out.WriteLine("x <= y : " + (x <= y));  // False 
            Out.WriteLine("x == y : " + (x == y));  // False 
            Out.WriteLine("x != y : " + (x != y));  // True

            // Assigment operators
            x *= y; // x = x * y;
            Out.WriteLine("x value now is " + x);
            x /= y;
            Out.WriteLine("x value now is " + x);
            x += y;
            Out.WriteLine("x value now is " + x);
            x -= y;
            Out.WriteLine("x value now is " + x);

            string firstName2 = "Sarah"; // condition ? 1conditon : 2condition
            Out.WriteLine(firstName == firstName2 ? (firstName + " " + lastName) : "Names was not mached");

            int[] arr = { 1, 2, 3 };
            Out.WriteLine(arr[1]);
            string str = "Hello";

            // Out.WriteLine(str[5]); <-- !!! Exception Out of range
        }
    }
}