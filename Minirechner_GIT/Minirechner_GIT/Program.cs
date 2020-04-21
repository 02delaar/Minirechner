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

     }
  }

