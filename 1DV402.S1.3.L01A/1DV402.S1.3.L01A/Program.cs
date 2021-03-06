﻿using System;
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

                antalloner = ReadInt("Antal löner att matta in: ");// anropar in metoden som har funktionen som låter än mata in antal löner man vill ha och kontrollerar att man matat in minst två personer.

                ProcessSalaries(antalloner);

                exit = Avsluta();// anropar metoden som har funktionen som avlutar programmet 
                   

            }

        }

        static int ReadInt(string text)
        {
            int ReadInt;

            while(true)
            {

           
            try // öppnar up möjligheten att hantera fel i chatch som kan uppstå i programmet
            {

                Console.Write(text);
                ReadInt = int.Parse(Console.ReadLine());

                if (ReadInt <= 1) // för att systemet ska funka måste man minst mata in 2 personers lön, gör man inte det så dyker det här fel meddelandet upp 
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du måste mata in en siffra som är större än 1 ");
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

        static void ProcessSalaries(int loner)
        {

            int Lon;

            int TotalLon;

            int MedianLon;

            int HogstaLon;

            int legstalonen;

            int lonespridningen;

            int genomsnittslonen;

            int[] AntalLoner;

            int[] LonerSorterat;

            TotalLon = 0;

            AntalLoner = new int[loner];

            LonerSorterat = new int[loner];

            int i1 = 0;

            for (int i = 0; i < loner; i++) //Loopar igenom arrayen för att läsa in värde i AntalLoner.
            {
                i1++;
               AntalLoner[i] = ReadInt(String.Format("Ange lön nummer {0}: ", i1 ));

               TotalLon += AntalLoner[i];

               LonerSorterat[i] = AntalLoner[i]; //kopiera arrayen AntalLoner till LonerSorterat
            }

            Array.Sort(LonerSorterat);

            HogstaLon = LonerSorterat.Max(); 

            legstalonen = LonerSorterat.Min();

            lonespridningen = HogstaLon - legstalonen;// ger lönespridningen 

            genomsnittslonen = TotalLon / loner;// ger genomsnittes lönen 

            Lon = LonerSorterat.Count();// får fram hur lång arrayen är och ger siffran till Lon variabeln 

            int s = LonerSorterat.Count() / 2;

            if (Lon % 2 == 0)
            {
                MedianLon = (LonerSorterat[s - 1] + LonerSorterat[s]) / 2;// medianen när det är jämna antal löner räknar vi ut genom att medelvärdet av de två mittersta lönerna beräknas 
            }

            else
            {
                MedianLon = LonerSorterat[s];// Är det ett udda antal löner bestäms medianlönen av den mittersta lönen. 
            }

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Medianlön:          {0:c0}", MedianLon);

            Console.WriteLine("Medellön:           {0:c0}", genomsnittslonen);

            Console.WriteLine("Lönespridning:      {0:c0}", lonespridningen);

            Console.WriteLine("--------------------------------");

            Console.WriteLine();


            int b1 = 3;

            for (int a = 1; a <= loner; a++) //Loopa igenom arrayen och läser upp den 
            {

                Console.Write("{0,8}   ", AntalLoner[a - 1]);
                
                if (a == b1)
                {
                    Console.WriteLine();
                    b1 = b1 + 3;

                }

            }

        }

         static int Avsluta()
        {

            int exit = 0;
            
            Console.WriteLine();//radbrytning
            Console.BackgroundColor = ConsoleColor.DarkGreen;//bakgrunds färg 
            Console.ForegroundColor = ConsoleColor.White;// färg på text 
            Console.WriteLine("Tryck på valfri tangent för att göra en ny beräkning - Escape avslutar programmet.");
            Console.ResetColor();

            ConsoleKeyInfo knap;
            knap = Console.ReadKey();

            Console.WriteLine();//radbrytning

            if (knap.Key == ConsoleKey.Escape)
            {
                exit = exit + 3;
               
            }

            return exit;
        }


    }
}
