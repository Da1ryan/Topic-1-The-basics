using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_1_The_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Darian";
            string favMovie = "THE MATRIX";
            string favQuote = "I fart in your general direction. Your mother was a hamster and your father smelt of elderberries...";

            favMovie.Replace('A', '@');
            favMovie.Replace('E', '3');
            Console.WriteLine("Hello i am " + firstName + ". My Favorite movie is " + favMovie.Replace('A', '@').Replace('E', '3'));
            Console.WriteLine("Does my favorite movie have a THE at the start? = " + favMovie.Contains("THE"));
            Console.WriteLine("My favorite quote is from monty python and the holy grail. " + favQuote.Replace('i', 'I').Replace('I', ' ').Replace('a', ' ').Replace('o', ' ').Replace('u', ' ').Replace('e', ' '));

            Console.WriteLine("                           ,--.                                          ");
            Console.WriteLine("                          {    }                                         ");
            Console.WriteLine("                          K,   }                                         ");
            Console.WriteLine("                         /  `Y`                                          ");
            Console.WriteLine("                    _   /   /                                            ");
            Console.WriteLine("                   {_'-K.__/                                             ");
            Console.WriteLine("                     `/-.__L._                                           ");
            Console.WriteLine("                     /  ' /`\\_}                                         ");
            Console.WriteLine("                    /  ' /                                               ");
            Console.WriteLine("            ____   /  ' /                                                ");
            Console.WriteLine("     ,-'~~~~    ~~/  ' /_                                                ");
            Console.WriteLine("   ,'             ``~~~%%',                                              ");
            Console.WriteLine("  (                     %  Y                                             ");
            Console.WriteLine(" {                      %% I                                             ");
            Console.WriteLine("{      -                 %  `.                                           ");
            Console.WriteLine("|       ',                %  )                                           ");
            Console.WriteLine("|        |   ,..__      __. Y                                            ");
            Console.WriteLine("|    .,_./  Y ' / ^Y   J   )|                                            ");
            Console.WriteLine("\\           |' /   |   |   ||                                           ");
            Console.WriteLine(" \\          L_/    . _ (_,.'(                                           ");
            Console.WriteLine("  \\,   ,     ^^^^' / |      )                                           ");
            Console.WriteLine("    \\_  \\          /,L]     /              _._    _,-'^^`-._           ");
            Console.WriteLine("      '-_`-,       ` `   ./`              (,-.`._,'(       |\\`-/|       ");
            Console.WriteLine("         `-(_            )                    `-.-' \\ )-`( , o o)       ");
            Console.WriteLine("             ^^\\..___,.--`                          `-    \\`_`^'-      ");

        }
    }
}
