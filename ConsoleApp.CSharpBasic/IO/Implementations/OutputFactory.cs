namespace ConsoleApp.CSharpBasics.IO.Implementations
{
    using System;
    using ConsoleApp.CSharpBasics.IO.Interfaces;

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
