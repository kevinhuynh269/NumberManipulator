using System;

namespace NumberManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
           var result = Int32.Parse(Console.ReadLine());
           result *= result;
           result+=14;
           result-=3;
           Console.WriteLine(result);
        }
    }
}
