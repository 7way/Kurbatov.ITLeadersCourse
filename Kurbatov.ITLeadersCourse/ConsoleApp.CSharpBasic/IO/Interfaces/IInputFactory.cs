using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CSharpBasic.IO.Interfaces
{
    public abstract class IInputFactory
    {
        public abstract IOutput GetOutputInstance(Type outputType);
    }
}
