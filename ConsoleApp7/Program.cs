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
            void regexnew(Regex rx)
            {
                using (StreamReader reader = new StreamReader("../../daten.txt"))
                {
                    string zeile;
                    while ((zeile = reader.ReadLine()) != null)
                    {
                        MatchCollection matchCollection = rx.Matches(zeile);
                        System.Diagnostics.Debug.WriteLine(matchCollection.Count);
                        foreach (Match item in matchCollection)
                        {
                     
                        }
                    }
                }
            }
            using (StreamReader reader = new StreamReader("../../daten.txt"))
            {
                string zeile;
                Regex rx = new Regex("bar|Bar|alive|Alive");
                while ((zeile = reader.ReadLine()) != null)
                {
                    MatchCollection matchCollection = rx.Matches(zeile);
                    System.Diagnostics.Debug.WriteLine(matchCollection.Count);
                    foreach (Match item in matchCollection)
                    {


                        // nimm das Code-snippet und mache eine Funktion daraus (am besten übergibst Du nur den String der Regular Expression) 
                        // und dann:
                        Console.WriteLine("");
                        
                        // Zähle folgende Strings in der Datei:
                        // bar
                        // Bar
                        // bar oder Bar

                        // alive
                        // Alive
                        // alive oder Alive

                        // alle Zeilen die entweder
                        // You got me rockin and a-rollin
                        // oder 
                        //Rockin and a - reelin

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
                    }


                    
                }
            }
            Console.ReadKey();
        }
    }
}
