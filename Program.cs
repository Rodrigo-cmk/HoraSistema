using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            DateTime agora = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("=>");
            Console.ResetColor();

            Console.Write(" A data e hora nesse momento são respectivamente: ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{agora}");
            Console.ResetColor();

        }
    }
}
