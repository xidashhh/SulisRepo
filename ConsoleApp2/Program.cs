using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int kockaDobottSzam = random.Next(6) + 1;
            Console.WriteLine(kockaDobottSzam);
        }
    }
}
