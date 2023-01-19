using System;

namespace _5.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var print = "";
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                int number = 0;
                string lettar = Console.ReadLine();
                for (int e = 0; e < lettar.Length; e++)
                {
                    count++;
                    number = int.Parse($"{lettar[e]}");
                }
                if (number == 0)
                {
                    print = print + " ";
                }
                else if (number == 2)
                {
                    print = $"{print}{Convert.ToChar(96 + count)}";
                }
                else if (number == 3)
                {
                    print = $"{print}{Convert.ToChar(99 + count)}";
                }
                else if (number == 4)
                {
                    print = $"{print}{Convert.ToChar(102 + count)}";
                }
                else if (number == 5)
                {
                    print = $"{print}{Convert.ToChar(105 + count)}";
                }
                else if (number == 6)
                {
                    print = $"{print}{Convert.ToChar(108 + count)}";
                }
                else if (number == 7)
                {
                    print = $"{print}{Convert.ToChar(111 + count)}";
                }
                else if (number == 8)
                {
                    print = $"{print}{Convert.ToChar(115 + count)}";
                }
                else if (number == 9)
                {
                    print = $"{print}{Convert.ToChar(118 + count)}";
                }
            }
            Console.WriteLine(print);
        }
    }
}
