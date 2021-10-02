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
            Random r = new Random();
            int answer;
            Console.WriteLine("Hi! It's NumberApp!");
            int number = r.Next(10, 20);

            {
                Console.WriteLine("Please input any number: ");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer < number)

                {
                    Console.WriteLine("You are wrong! Your number is less!");
                }

                {
                    if (answer > number)

                    {
                        Console.WriteLine("You are wrong! Your number is grater!");
                    }

                    {
                        if (answer == number)

                        {
                            Console.WriteLine("Correct! This is #.");
                           
                        }

                    }

                }
            }
        }
    }
}
