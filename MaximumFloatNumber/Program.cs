using System;
namespace MaximumFloatNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Max Float Number");
            double output = MaxFloat.MaximumFloatNumber(11.11, 22.22, 33.33);
            Console.WriteLine(output);
        }
    }
}
