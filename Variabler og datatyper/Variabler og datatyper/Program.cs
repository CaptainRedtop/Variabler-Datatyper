using System;

namespace Variabler_og_datatyper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave a
            int length = 16;
            double width = 5.1;
            //Opgave b
            int area = width * length; //Kan ikke lade sig gøre fordi en int ikke kan indeholde en double(Kommatal).
            //Opgave c
            double d = width * length; //Kan lade sig gøre fordi double godt kan indeholde en int(Heltal).

            Console.WriteLine(length * width);
            Console.ReadLine();
        }
    }
}
