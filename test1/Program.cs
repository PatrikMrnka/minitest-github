using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args) => Console.WriteLine(PowerOfTwo(Convert.ToInt32(Console.ReadLine())))

        static int PowerOfTwo(int a)
        {
            int vysledek = a * a;
            return vysledek;
        }
        static int WriteStars(int b)
        {

        }
    }
}
