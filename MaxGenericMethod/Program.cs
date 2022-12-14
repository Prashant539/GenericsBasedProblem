using System;
namespace MaxGenericMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 112, 123, 234, 345 };
            GenericMaxNumber<int> generic = new GenericMaxNumber<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 112.33, 123.53, 234.43, 345.63 };
            GenericMaxNumber<double> genericDouble = new GenericMaxNumber<double>(doubleArray);
            genericDouble.PrintMaxValue();

            string[] stringArray = { "234", "673", "359", "872" };
            GenericMaxNumber<string> genericString = new GenericMaxNumber<string>(stringArray);
            genericString.PrintMaxValue();
        }
    }
}
