using System;
namespace MaximumStringProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Max String");
            string output =MaxString.MaximumString("apple", "banana", "prashant" );
            Console.WriteLine(output);
        }
    }
}
