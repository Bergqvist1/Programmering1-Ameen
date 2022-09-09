using System;
namespace Uppgift_2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            string strDagar = Console.ReadLine();
            Console.WriteLine("Hur många kilometer ska du ströga med bilen i kilometer?"); 
            string strStrög = Console.ReadLine();

            int intDagar = int.Parse(strDagar);
            int intStrög = int.Parse(strStrög);

            int Summa = 300 + intDagar * 500 + intStrög * 1 + 500;

            Console.WriteLine("Strögen kommer att kosta dig " + Summa + "kr");

            
        }
    }
}