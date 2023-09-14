namespace Ny_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min fantastiske menu");
            Console.WriteLine("1. Gør dit");
            Console.WriteLine("2. Gør dat");
            Console.Write("Indtast enten 1 eller 2 for valgmulighederne eller indtast 5 for at slutte programmet: ");
            int indtastedenummer = int.Parse(Console.ReadLine());
            for (indtastedenummer = 0; indtastedenummer > 2)
            {
                Console.WriteLine("Indtast en korrekt valgmulighed");
                Console.ReadLine();
                break;
            }
        }   
    }
}