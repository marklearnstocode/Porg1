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
            switch (indtastedenummer)
            {
                case 1:
                    Console.Write("Du har valgt {0}, så gør dit!", indtastedenummer);
                    break;

                case 2:
                    Console.Write("Du har valgt {0}, så gør dat!", indtastedenummer);
                    break;

                case 3:
                    Console.Write("Du har valgt {0}, så gør noget", indtastedenummer);
                    break;

                case 4:
                    Console.Write("Du har valgt {0} for at få svaret på livet og alt andet godt", indtastedenummer);
                    break;

                default:
                    Console.Write("du har valgt forkert dummy");
                    break;
            }        
        }
    }
}