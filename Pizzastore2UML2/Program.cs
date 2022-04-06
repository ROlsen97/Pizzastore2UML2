using System;

namespace Pizzastore2UML2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store start = new Store();
            start.start();

            Console.WriteLine();
            Console.WriteLine("Press key to close program");
        }
    }
}
