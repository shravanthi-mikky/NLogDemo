using System;

namespace NlogDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddNumbers addNumbers = new AddNumbers();
            int result = addNumbers.Sum(12, 0);
            Console.WriteLine(result);

        }
    }
}
