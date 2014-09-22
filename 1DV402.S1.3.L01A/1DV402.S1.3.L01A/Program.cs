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

                antalloner = ReadInt("Antal löner att matta in: ");// anropar in metoden som har funktionen som låter än mata in antal löner man vill ha och kontrollerar att man matat in minst två personer.

                ProcessSalaries(antalloner);

                   exit = Avsluta();//// anropar metoden som har funktionen som avlutar programmet 
                   

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

            int ReknaLon;

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

            for (int i = 0; i < loner; i++) //Loopa igenom arrayen´för att läsa in och tilldela värde i AntalLoner.
            {
               AntalLoner[i] = ReadInt(String.Format("Ange lön nummer {0}: ", i + 1));

               TotalLon += AntalLoner[i];

               LonerSorterat[i] = AntalLoner[i]; //kopiera arrayen AntalLoner till LonerSorterat.
            }

            Array.Sort(LonerSorterat);

            HogstaLon = LonerSorterat.Max();
            legstalonen = LonerSorterat.Min();
            lonespridningen = HogstaLon - legstalonen;
            genomsnittslonen = TotalLon / loner;

            ReknaLon = LonerSorterat.Count();

            for (int a = 0; a < loner; a++) //Loopa igenom arrayen och läser upp den 
            {
                
                Console.WriteLine("det är inte en siffra " + LonerSorterat[a]);

                
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
