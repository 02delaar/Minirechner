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
            int ZahlA =0 ;
            string strOperant = " ";
            int ZahlB = 0;
            
            Titel("Minirechner");

            ZahlA = Zahl_A_Eingabe();
            strOperant = Operant_Eingabe();
            ZahlB = Zahl_B_Eingabe();

            Berechnen(ZahlA, ZahlB, strOperant);

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

        static int Zahl_A_Eingabe()
        {
            int ZahlA;
            Console.Write("Bitte geben Sie die 1. Zahl ein: ");

            while (!Int32.TryParse(Console.ReadLine(), out ZahlA) || ZahlA < 1)             //Zahl < 1 wäre falsch, jedoch wegen des OR davor stimmt das!
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FEHLER. Bitte wählen sie eine Verfügbare Zahl!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            return ZahlA;
        }

        static string Operant_Eingabe()
        {
            string strOperant;
            Console.Write("Bitte geben Sie den Operant ein: ");
            strOperant = Console.ReadLine();
            return strOperant;
            
        }

        static int Zahl_B_Eingabe()
        {
            int ZahlB;
            Console.Write("Bitte geben Sie die 2. Zahl ein: ");

            while (!Int32.TryParse(Console.ReadLine(), out ZahlB) || ZahlB < 1)             //Zahl < 1 wäre falsch, jedoch wegen des OR davor stimmt das!
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FEHLER. Bitte wählen sie eine Verfügbare Zahl!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            return ZahlB;
        }



        static void Berechnen(int ZahlA, int ZahlB, string strOperant)
        {
            switch (strOperant)
            {
                case "+":
                    Console.WriteLine("Das Ergebnis beträgt: " + (ZahlA + ZahlB));
                    break;

                case "-":
                    Console.WriteLine("Das Ergebnis beträgt: " + (ZahlA - ZahlB));
                    break;

                case "*":
                    Console.WriteLine("Das Ergebnis beträgt: " + (ZahlA * ZahlB));
                    break;

                case "/":
                    Console.WriteLine("Das Ergebnis beträgt: " + (ZahlA / ZahlB));
                    break;

                default:
                    Console.WriteLine("Bitte wähle einen Unterstützten Operant wie +,-,*,/ ");
                    break;
    
            }

        }

     }
  }

