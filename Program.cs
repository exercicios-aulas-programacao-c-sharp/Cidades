using System;

namespace Cidades
{
    class Program
    {
        //Faça um programa que exiba os nomes das cidades do litoral sul de São Paulo, um em cada linha.
        static void Main(string[] args)
        {
            Console.WriteLine("\\-------------------------\\");
            Console.WriteLine("|  Cidades do Litoral Sul |");
            Console.WriteLine("\\-------------------------\\\n");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine("Peruíbe, \"no rio dos tubarões\"");

            Console.Write("Peruíbe,\t");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\"no rio dos tubarões\"");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Itanhaém,\t\"pedra que canta\"");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Mongaguá,\t\'água pegajosa\'");
            Console.ResetColor(); 
        }
    }
}
