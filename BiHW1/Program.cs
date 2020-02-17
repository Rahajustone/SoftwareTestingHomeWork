using System;

namespace BiHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's create an object of our class
            BiHwOne b = new BiHwOne(100, 200, 10);

            // Get X variable
            Console.WriteLine($"X:{b.GetX()}");

            // Get X variable
            Console.WriteLine($"Y:{b.GetY()}");
            
            Console.WriteLine($"Sum of total Array: { b.GetSumTotalOfArray() }");

            b.SetArrayList(10);
            Console.WriteLine($"Sum of total ArrayList: { b.GetSumOfTotalArrayList() }");
        }
    }
}
