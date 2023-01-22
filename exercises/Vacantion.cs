using System;
using System.Net.NetworkInformation;

namespace _3._Vacantion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            decimal price = 0m;
            decimal cost = 0m;
            if (typeGroup == "Students")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        price = 8.45m;
                        break;
                    case "Saturday":
                        price = 9.80m;
                        break;
                    case "Sunday":
                        price = 10.46m;
                        break;
                }
                if (countOfPeople >= 30)
                {
                   cost = price * countOfPeople * 0.85m;
                }
                else
                {
                    cost = price * countOfPeople;
                }
            }
            else if (typeGroup == "Business")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        price = 10.9m;
                        break;
                    case "Saturday":
                        price = 15.6m;
                        break;
                    case "Sunday":
                        price = 16m;
                        break;
                }
                if (countOfPeople >= 100)
                {
                    countOfPeople -= 10;
                }
                cost = price * countOfPeople;
            }
            else if (typeGroup == "Regular")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        price = 15m;
                        break;
                    case "Saturday":
                        price = 20m;
                        break;
                    case "Sunday":
                        price = 22.5m;
                        break;
                }
                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    cost = price * countOfPeople * 0.95m;
                }
                else
                {
                    cost = price * countOfPeople;
                }
            }
                Console.WriteLine($"Total price: {cost:f2}");
        }
    }
}
