//NAME: SALANDANAN, MATHEOUS
//COURSE & SECTION: BSCpE 1-1

using System;

namespace Item1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 3;
            while (counter != 0)
            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();

                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                if (username == "Admin" && password == "Admin1234!")
                {
                    Console.Clear();
                    Console.WriteLine("Login is successful!");
                    break;
                    
                }
                else
                {
                    Console.Clear();
                    counter --;
                    Console.WriteLine($"Login is unsuccessful! Remaining Attempts: {counter}");
                }
            }


        }
    }
}
