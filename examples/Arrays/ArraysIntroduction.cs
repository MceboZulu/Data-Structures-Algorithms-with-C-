using System;

namespace DSA.Examples.Arrays
{
    public class ArraysIntroduction
    {
        public static void Run()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Array values:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Index {i}: {numbers[i]}");
            }
        }
    }
}