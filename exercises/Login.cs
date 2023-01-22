using System;

namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string newPassword = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                newPassword += username[i];
            }
            int count = 0;
            Boolean check = true;
            while (check)
            {
                if (newPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    check = false;
                    break;
                }
                count++;
                if (count >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    check = false;
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
            }            
        }
    }
}
