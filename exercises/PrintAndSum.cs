﻿using System;

namespace _4.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ",i);
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
