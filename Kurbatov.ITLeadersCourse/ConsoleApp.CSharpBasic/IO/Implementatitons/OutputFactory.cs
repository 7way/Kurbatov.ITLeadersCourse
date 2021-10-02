using ConsoleApp.CSharpBasic.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CSharpBasic.IO.Inplementatitons
{
    public class OutputFactory : IOutputFactory
    {
        public class OutputFactory : IOutputFactory
        {
            public override IOutput GetOutputInstance(Type outputType)
            {
                switch (outputType)
                {
                    case Type when outputType == typeof(ConsoleOutput):
                        return new ConsoleOutput();
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
