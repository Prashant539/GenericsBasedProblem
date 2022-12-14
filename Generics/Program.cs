using System;
namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            SampleCode.toPrint(intArray);
            SampleCode.toPrint(charArray);
            SampleCode.toPrint(doubleArray);
        }
    }
}


