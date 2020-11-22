using System;

namespace Lesson007_Task1
{
    class Program
    {
        static void Calculate(int a, uint b)
        {
            Console.WriteLine(a+b);
        }
        static void Calculate(byte a, sbyte b)
        {
            Console.WriteLine(a+b);
        }
        static void Calculate(long a, ulong b)
        {
            Console.WriteLine(a+(long)b);
        }

        static void Main(string[] args)
        {
            int a = 15, b = 46;
            Calculate((byte)a, (sbyte)b);
           
            Calculate((int)a, (uint)b);
           
            Calculate((long)a, (ulong)b);

        }
    }
}
