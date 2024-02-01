using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(a > b)
            {
                if(b == 0)
                {
                    Console.WriteLine("Знаменатель не должен равняться 0");
                    Environment.Exit(0);
                }
                else
                {
                    x = a / b + 1;
                }
            }
            else if(a < b)
            {
                if(a == 0) 
                {
                    Console.WriteLine("Знаменатель не должен равняться 0");
                    Environment.Exit(0);
                }
                else
                {
                    x = (a * b - 2) / a;
                }
            }
            else
            {
                x = a + 25;
            }

            Console.WriteLine(x);
        }
    }
}
