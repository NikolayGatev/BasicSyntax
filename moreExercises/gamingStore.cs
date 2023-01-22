using System;

namespace _3.gamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal balans = decimal.Parse(Console.ReadLine());
            string gameName = Console.ReadLine();
            decimal spendSum = 0;
            while (gameName != "Game Time")
            {
                if (gameName == "OutFall 4")
                {
                    if (balans - spendSum >= 39.99m)
                    {
                        Console.WriteLine($"Bought {gameName}");
                        spendSum += 39.99m;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "CS: OG")
                {
                    if (balans - spendSum >= 15.99m)
                    {
                        Console.WriteLine($"Bought {gameName}");
                        spendSum += 15.99m;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "Zplinter Zell")
                {
                    if (balans - spendSum >= 19.99m)
                    {
                        Console.WriteLine($"Bought {gameName}");
                        spendSum += 19.99m;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "Honored 2")
                {
                    if (balans - spendSum >= 59.99m)
                    {
                        Console.WriteLine($"Bought {gameName}");
                        spendSum += 59.99m;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "RoverWatch")
                {
                    if (balans - spendSum >= 29.99m)
                    {
                        Console.WriteLine($"Bought {gameName}");
                        spendSum += 29.99m;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    if (balans - spendSum >= 39.99m)
                    {
                        Console.WriteLine($"Bought {gameName}");
                        spendSum += 39.99m;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (spendSum == balans)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                gameName = Console.ReadLine();
            }
            if (balans > spendSum)
                Console.WriteLine($"Total spent: ${spendSum}. Remaining: ${balans - spendSum}");
        }
    }
}
