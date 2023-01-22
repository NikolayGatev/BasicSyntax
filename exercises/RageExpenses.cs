using System;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal priceHeadset = decimal.Parse(Console.ReadLine());
            decimal priceMouse = decimal.Parse(Console.ReadLine());
            decimal priceKeyboard = decimal.Parse(Console.ReadLine());
            decimal priceDisplay = decimal.Parse(Console.ReadLine());
            int trashesHeadset = lostGames / 2;
            int trashesMouse = lostGames / 3;
            int trashesKeyboard = lostGames / 6;
            int trashesDisplay = lostGames / 12;
            decimal trashesSum = priceHeadset * trashesHeadset + priceMouse * trashesMouse + priceKeyboard * trashesKeyboard + priceDisplay * trashesDisplay;
            Console.WriteLine($"Rage expenses: {trashesSum:f2} lv.");

        }
    }
}
