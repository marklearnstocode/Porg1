using System;

namespace min_fantastiske_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min fantastiske menu");
            Console.WriteLine("1. Gør dit");
            Console.WriteLine("2. Gør dat");
            Console.WriteLine("3. Gør noget");
            Console.WriteLine("4. Få svaret på livet og alt andet godt");
            Console.Write("Indtast enten 1, 2, 3 eller 4: ");
            int indtastedenummer = int.Parse(Console.ReadLine());
            while(indtastedenummer < 0 || indtastedenummer > 4)
            {
            Console.WriteLine("Indtast en korrekt valgmulighed");
            }
           
            }        
        }
    }
