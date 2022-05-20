using System;

namespace Debugging;

class Program // Her tester jeg mest bare Breakpoints i koden som kan være til hjelp for å finne bugs og se grundigere hva som skjer i hvert trinn i koden.
{
    static void Main(string[] args)
    {
        var range = 250;
        var counts = new int[range];
        string text = "something";
        while (!string.IsNullOrWhiteSpace(text))
        {
            text = Console.ReadLine();
            foreach (var character in text ?? string.Empty)
            {
                counts[(int)character]++;
            }
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i; 
                    Console.WriteLine( character + " - " + counts[i] );
                }
            }
        }
    }
}
// Sjekk at counts-arrayet blir oppdatert for hver character i teksten.
// Finn ut hvilke verdier variablen “i” må ha i for-løkken for at den skal treffe breakpointet på linje 23.
// (trykk F5 når du er i for-løkken isteden for F10).

// I = 32??