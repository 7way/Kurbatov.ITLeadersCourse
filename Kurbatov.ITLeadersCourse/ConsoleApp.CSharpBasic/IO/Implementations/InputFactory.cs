using ConsoleApp.CSharpBasic.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CSharpBasic.IO.Implementations
    public class InputFactory : IInputFactory
{

    public override IInput GetInputInstance(Type inputType)
    {
        switch (inputType)
        {
            case Type when inputType == typeof(ConsoleInput):
                return new ConsoleInput();
            default:
                throw new NotImplementedException();
        }
    }
}
}
