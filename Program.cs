using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Für_Praktikum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string antwort;

            do
            {
                Console.Clear();
                
                Console.WriteLine("=== WILLKOMMEN ZUM TASCHENRECHNER! ===");
                Console.Write("\nGib die Zahlen ein: ");

                double zahl1, zahl2;

                Console.Write("\nZahl 1: ");
                while (!double.TryParse(Console.ReadLine(), out zahl1))
                {
                    Console.Write("Keine gültige Zahl! Bitte erneut eingeben: ");
                }

                Console.Write("Zahl 2: ");
                while (!double.TryParse(Console.ReadLine(), out zahl2))
                {
                    Console.Write("Keine gültige Zahl! Bitte erneut eingeben: ");
                }

                Console.Write("\nWelche Grundrechenart? (+ , - , * , /) ");
                string rechenart = Console.ReadLine();

                if (rechenart == "+")
                {
                    Console.WriteLine("\nDas Ergebnis ist " + (zahl1 + zahl2) + ".");
                }
                else if (rechenart == "-")
                {
                    Console.WriteLine("\nDas Ergebnis ist " + (zahl1 - zahl2) + ".");
                }
                else if (rechenart == "*")
                {
                    Console.WriteLine("\nDas Ergebnis ist " + (zahl1 * zahl2) + ".");
                }
                else if (rechenart == "/")
                {
                    if (zahl2 == 0)
                    {
                        Console.WriteLine("\nFehler! Division durch 0 ist mathematisch nicht möglich!");
                    }
                    else
                    {
                        Console.WriteLine("\nDas Ergebnis ist " + (zahl1 / zahl2) + ".");
                    }
                }
                else
                {
                    Console.WriteLine("\nUngültige Eingabe!");
                }

                Console.Write("\nWillst du eine neue Berechnung durchführen? (ja/nein) ");
                antwort = Console.ReadLine();

            }
            while (antwort.ToLower() == "ja");

            Console.WriteLine("\nAuf Wiedersehen! Zum Beenden ENTER drücken.");
            Console.ReadLine();
        }
    }
}
