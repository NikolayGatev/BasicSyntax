using System;

namespace _6.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            string strNumber = number.ToString();
            int factorial = 1;
            for (int i = 0; i < strNumber.Length; i++)
            {
                int curentI = int.Parse($"{strNumber[i]}");
                for (int e = 1; e <=curentI; e++)
                {
                    factorial *= e;
                }
                sum += factorial;
                factorial = 1;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
