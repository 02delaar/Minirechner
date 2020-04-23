using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minirechner_GIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Titel("Minirechner");
            Abfrage();

            Console.ReadKey();
        }

        static void Titel(string Text)
        {
            int breite = Console.WindowWidth;
            int textlaenge = Text.Length;
            Console.Clear();
       
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
            for (int i = 0; i < (breite/2)-textlaenge; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(Text);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");   
            }
       
        }

        public static void Abfrage()
        {
            int ZahlA = 0;
            string strOperant = " ";
            int ZahlB = 0;

            Console.Write("Bitte geben Sie die 1. Zahl ein: ");
            ZahlA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte geben Sie den Operant ein: ");
            strOperant = Console.ReadLine();
            Console.Write("Bitte geben Sie die 2. Zahl ein: ");
            ZahlB = Convert.ToInt32(Console.ReadLine());
            
        }

     }
  }

