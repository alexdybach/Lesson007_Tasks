using System;

namespace Lesson007_Task3
{
    class Program
    {
        static int Suma(int a, int b, int suma)
        {
            int suma1 = 0;
            if (a <= b)
            {
                suma += a;
                a++;
                //Console.WriteLine($"suma = {suma}");

                Suma(a, b, suma);
            }
            else
                suma1 = suma;
            return suma1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numbers: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int suma = 0;
            Console.WriteLine($"Suma = {Suma(n, m, suma)}");
        }
    }
}
