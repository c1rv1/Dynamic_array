using System;
using System.Collections.Generic;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<short> digits = new List<short>() { 45, 12, 52, 71 };

            digits.Add(4);

            digits.AddRange(new short[] { 7, 3, 5, 3 });

            digits.Insert(1, 178);

            digits.Remove(12);

            digits.RemoveAt(2);

            digits.Sort();

            Console.WriteLine(digits[2]);

            Console.ReadKey();
        }
    }
}
