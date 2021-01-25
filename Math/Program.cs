using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            calculate.Add(5, 8);
            Console.WriteLine("----------");
            calculate.Add(123456, 2345678);
        }
    }
}
