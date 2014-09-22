using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1._3.L01A
{
    class Program
    {
        static void Main(string[] args)
        {

            int antalloner = 0;

            int exit = 0;

            while(exit < 2)
            {

                antalloner = ReadInt();// läser in metoden som har funktionen som låter än mata in antal löner man vill ha och kontrollerar att man matat in minst två personer.

                   Console.WriteLine(antalloner); 
                   Console.ReadKey();

                   Console.WriteLine();//radbrytning
                   Console.BackgroundColor = ConsoleColor.DarkGreen;//bakgrunds färg 
                   Console.ForegroundColor = ConsoleColor.White;// färg på text 
                   Console.WriteLine("Tryck på valfri tangent för att göra en ny beräkning - Escape avslutar programmet.");
                   Console.ResetColor();

                   ConsoleKeyInfo knap;
                   knap = Console.ReadKey();

                   Console.WriteLine();//radbrytning

                if(knap.Key == ConsoleKey.Escape)
                {
                    exit = exit + 3;
                }

                   

            }

        }

        static int ReadInt()
        {
            int ReadInt;

            while(true)
            {

           
            try // öppnar up möjligheten att hantera fel i chatch som kan uppstå i programmet
            {

                Console.Write("Antal löner att matta in: ");
                ReadInt = int.Parse(Console.ReadLine());

                if (ReadInt <= 1) // för att systemet ska funka måste man minst mata in 2 personers lön, gör man inte det så dyker det här fel meddelandet upp 
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du måste mata in minst två löner för att kunna göra en bräkning!");
                    Console.ResetColor();
                }
                else // har man mattat in minst 2 personers så abryts while satsen 
                {
                    break;
                }

            }

            catch // skriver man en bokstav, punkt eller något som inte uppfattas som ett tal så visas det här
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("det är inte en siffra");
                Console.ResetColor();
            }

            
            }

            return ReadInt;
        }  


    }
}
