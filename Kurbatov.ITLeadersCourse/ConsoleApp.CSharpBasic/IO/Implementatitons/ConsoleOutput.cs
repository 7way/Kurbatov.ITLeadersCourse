using ConsoleApp.CSharpBasic.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CSharpBasic.IO.Inplementatitons
{
    public class ConsoleOutput : IOutput
    {
        public void Write(object output = null)
        {
            Console.Write(output);
        }

        public void WriteLine(object output = null)
        {
            if (output == null)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(output);
            }
        }
    }
}
