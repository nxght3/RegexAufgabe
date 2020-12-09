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
         regexnew(new Regex("You got me rockin and a-rollin|Rockin and a - reelin"));
         regexnew(new Regex("evolution"));
         regexnew(new Regex("brother|mother")); 
         regexnew(new Regex("you| you're"));
         regexnew(new Regex(".*know"));
         regexnew(new Regex("\\sa(.*)"));
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
                        Console.Write(item);
                        i++;
                    }
                }

            }
            Console.WriteLine(i);

        }
    }
}
