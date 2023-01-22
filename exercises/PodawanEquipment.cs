using System;

namespace _9.PodawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            decimal priceLightsabels = decimal.Parse(Console.ReadLine());
            decimal priceRobels = decimal.Parse(Console.ReadLine());
            decimal priceBelts = decimal.Parse(Console.ReadLine());
            decimal lightsabels = Math.Ceiling(countStudents * 1.1m);
            int belts = countStudents - (countStudents / 6);
            decimal bill = (belts * priceBelts) + (lightsabels * priceLightsabels) + (priceRobels * countStudents);
            if (amountOfMoney < bill)
            {
                Console.WriteLine($"John will need {(bill - amountOfMoney):F2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {bill:f2}lv.");
            }
        }
    }
}
