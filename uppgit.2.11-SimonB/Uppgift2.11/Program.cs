using System;
namespace Uppgift_2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin mätt i meter?");
            string längdText = Console.ReadLine();
            double längd = double.Parse(längdText);
            Console.WriteLine("Hur långt hoppade Alma i meter?");
            string längd2text = Console.ReadLine();
            double längd2 = double.Parse(längd2text);
            double skillnad = längd - längd2;
            Console.WriteLine("Elin hoppade " + skillnad + " meter längre.");
        }
    }
}