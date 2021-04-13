using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter a number: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Addition of {0}, {1} = {2}", a,b,MyClass.add(a,b));
            Console.WriteLine("Subtraction of {0}, {1} = {2}", a,b,MyClass.subtract(a,b));
            Console.WriteLine("Multiplicatioin of {0}, {1} = {2}", a,b,MyClass.mul(a,b));
            Console.WriteLine("Division of {0}, {1} = {2}", a,b,MyClass.divide(a,b));
        }
    }
}
