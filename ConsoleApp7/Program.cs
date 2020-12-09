using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        
        static void Main(string[] args)
        {

         regexnew(new Regex("bar|Bar"));                                  
         regexnew(new Regex("alive|Alive"));
            // alle Zeilen die entweder
            // You got me rockin and a-rollin
            // oder 
            //Rockin and a - reelin
         regexnew(new Regex(""));
                        // "brother" oder "mother" aber sonst nichts

                        // evolution ohne ein "r" davor

                        // "you" oder "you're" aber kein "your"  

                        // know am Ende einer Zeile

                        // wieviele Worte beginnen mit jedem buchstaben des Alphabets- daher Anzahl aller *Worte* die mit "a" beginnen (case-insensitive), b, c, d ...

                        // komplizierter: gib die Zeilen aus die 
                        // Bands und Liedertitle enthalten
                        // nur die Bands
                        // nur die Liedertitel
                        // die Anzahl der Zeilen jedes Liedtitles
            Console.ReadKey();
        }
        static void regexnew(Regex rx)
        {
            int i = 0;
            using (StreamReader reader = new StreamReader("../../daten.txt"))
            {
                string zeile;
                while ((zeile = reader.ReadLine()) != null)
                {
                    MatchCollection matchCollection = rx.Matches(zeile);
                    System.Diagnostics.Debug.WriteLine(matchCollection.Count);
                    foreach (Match item in matchCollection)
                    {
                        i++;
                    }
                }

            }
            Console.WriteLine(i);

        }
    }
}
