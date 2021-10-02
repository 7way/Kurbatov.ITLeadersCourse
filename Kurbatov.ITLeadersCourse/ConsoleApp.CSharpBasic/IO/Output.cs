using ConsoleApp.CSharpBasic.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CSharpBasic.IO
{
    public class Output
    {
        private static IOutput output;

        public static IOutput Out
        {
            get
            {
                if(output == null)
                {
                    output = new IOutputFactory().GetOutputInstance(typeof(ConsoleOutput));
                }

                return output;
            }
        }

    }
}
