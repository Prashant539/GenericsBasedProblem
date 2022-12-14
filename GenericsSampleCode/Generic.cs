using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSampleCode
{
    internal class Generic
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var item in inputArray)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("...........");
        }
    }
}
