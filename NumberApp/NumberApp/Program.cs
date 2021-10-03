using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int answer;
            int number = rand.Next(10, 20);

            Console.WriteLine("Hi! It's NumberApp!");

            {
                Console.WriteLine("Please input any number: ");
                answer = Convert.ToInt32(Console.ReadLine());

                if (answer < number)

                  {
                    Console.WriteLine("You are wrong! Your number is less!");
                  }

                else if (answer > number)

                  {
                    Console.WriteLine("You are wrong! Your number is grater!");
                  }
                
                   
                if (answer == number)
                   
                  {
                    Console.WriteLine("Correct! This is: ", number);
                           
                  }
                     
                    }

                }
            }
}
