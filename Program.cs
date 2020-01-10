using System;

namespace DotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new FibonaciGenerator();
            foreach (var digit in generator.Generate(20))
            {
                Console.WriteLine(digit);
            }
        }
    }
}
