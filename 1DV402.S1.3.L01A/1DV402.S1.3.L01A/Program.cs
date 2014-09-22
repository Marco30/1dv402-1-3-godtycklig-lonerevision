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

                    antalloner = ReadInt();

                    Console.WriteLine(antalloner); 
                   Console.ReadKey();

                   exit++;

            }

        }

        static int ReadInt()
        {
            int ReadInt;

            while(true)
            {

           
            try // öppnar up möjligheten att hantera fel chatch som kan uppstå i programmet
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
