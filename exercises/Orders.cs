using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOrder = int.Parse(Console.ReadLine());
            decimal orderSum = 0;
            decimal totalSum = 0;
            for (int i = 0; i < countOrder; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                orderSum = capsulesCount * pricePerCapsule * days;
                Console.WriteLine($"The price for the coffee is: ${orderSum:F2}");
                totalSum += orderSum;
            }
            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
