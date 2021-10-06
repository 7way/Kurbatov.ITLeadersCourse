namespace ConsoleApp.CSharpBasics
{
    using System;
    using static ConsoleApp.CSharpBasics.IO.Output;

    class Program { }
    
        static void Main(string[] args)
    {

        int[] integerArray = { 1, 2, 3, 4, 5 }; //инициализируем масссив

        int[] integerArray = new int[5]; // выделяем память массиву]

         for (int i = integerArray.Length - 1; i>=0; i--) //условие 

        {
            Out.WriteLine(integerArray[i]); //вывод элементов массива
        }
           
    }
}