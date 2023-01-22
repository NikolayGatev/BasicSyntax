using System;

namespace _7.vendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string into = Console.ReadLine();
            decimal bill = 0m;
            decimal coin = 0;
            decimal sumCoin = 0;
            while (into != "Start")
            {
                coin = decimal.Parse(into);
                if (coin == 0.1m || coin == 0.2m || coin == 0.5m || coin == 1m || coin == 2m)
                {
                    sumCoin += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                into = Console.ReadLine();
            }
            while (into != "End")
            {
                if (into != "Start")
                {
                    if (into == "Nuts" || into == "Water" || into == "Crisps" || into == "Soda" || into == "Coke")
                    {
                        if (into == "Nuts" && ((sumCoin - bill) >= 2m))
                        {
                            bill += 2m;
                            Console.WriteLine($"Purchased nuts");
                        }
                        else if (into == "Water" && ((sumCoin - bill) >= 0.7m))
                        {
                            bill += 0.7m;
                            Console.WriteLine($"Purchased water");
                        }
                        else if (into == "Crisps" && ((sumCoin - bill) >= 1.5m))
                        {
                            bill += 1.5m;
                            Console.WriteLine($"Purchased crisps");
                        }
                        else if (into == "Soda" && ((sumCoin - bill) >= 0.8m))
                        {
                            bill += 0.8m;
                            Console.WriteLine($"Purchased soda");
                        }
                        else if (into == "Coke" && ((sumCoin - bill) >= 1m))
                        {
                            bill += 1m;
                            Console.WriteLine($"Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough mone");
                        }
                    }
                    if (into != "Nuts" && into != "Water" && into != "Crisps" && into != "Soda" && into != "Coke")
                    {
                        Console.WriteLine("Invalid product");
                    }
                }
                into = Console.ReadLine();
            }
            Console.WriteLine($"Change: {(sumCoin - bill):f2}");
        }
    }
}
