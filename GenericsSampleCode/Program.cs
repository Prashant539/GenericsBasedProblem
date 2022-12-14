using GenericsSampleCode;
using System;
namespace GenericsBasedCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, };

            double[] doubleArray = { 1.1, 2.2, 3.3 };
            char[] charArray = { 'a', 'b', 'c', 'd' };
            Generic.toPrint<int>(intArray);
            Generic.toPrint<double>(doubleArray);
            Generic.toPrint<char>(charArray);
        }
    }
}







